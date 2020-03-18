using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    List<GameObject> opponentList;
    public GameObject target;
    NavMeshAgent agent;
    public float distance;
    void Start()
    {
        if (GetComponent<Info>().team == "A") opponentList = GameManager.instance.teamB;
        else if (GetComponent<Info>().team == "B") opponentList = GameManager.instance.teamA;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (opponentList.Count == 0)
        {
            target = null;
            Debug.Log("Lost em!");
        }            
        if (target == null || (target != null && Vector3.Distance(agent.transform.position, target.transform.position) > GetComponent<Info>().range + 4)) FindTarget();
    }

    private void FindTarget()
    {
        if (opponentList.Count == 0) target = null;
        else 
        {
            //Target first
            target = opponentList[0];
            //Calculate Distance to target
            distance = Vector3.Distance(agent.transform.position, opponentList[0].transform.position);
            //Check each other in the list
            foreach (GameObject c in opponentList)
            {
                //If the distance to them is shorter
                if (Vector3.Distance(agent.transform.position, c.transform.position) < distance)
                {
                    //They are the target, new distance
                    target = c;
                    distance = Vector3.Distance(agent.transform.position, c.transform.position);
                }
            }
        }            
    }
}