using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backstab : MonoBehaviour
{
    List<GameObject> opponentList;
    void Start()
    {
        if (GetComponent<Info>().team == "A") opponentList = GameManager.instance.teamB;
        else if (GetComponent<Info>().team == "B") opponentList = GameManager.instance.teamA;
    }
    internal void Cast(GameObject target)
    {
        target = opponentList[0];
        int hp = opponentList[0].GetComponent<Health>().hp;
        //Check each other in the list
        foreach (GameObject c in opponentList)
        {
            if (c.GetComponent<Health>().hp < hp)
            {
                target = c;
                hp = c.GetComponent<Health>().hp;
            }
        }
        GameObject backstab = target.GetComponent<TargetLocation>().back;            
        GetComponent<Transform>().position = new Vector3(backstab.transform.position.x, transform.position.y, backstab.transform.position.z);
        GetComponent<Target>().target = target;
        GetComponent<Control>().LookAt(target.transform.position - transform.position, 15);
    }
}
