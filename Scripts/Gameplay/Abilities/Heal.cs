using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int heal;
    GameObject target;
    int howFarFromFull;

    internal void Cast()
    {        
        if (GetComponent<Info>().team == "A") target = FindTarget(GameManager.instance.teamA);
        else if (GetComponent<Info>().team == "B") target = FindTarget(GameManager.instance.teamB);
        if (howFarFromFull > 0)
        {
            target.GetComponent<CombatInfoUI>().Heal(heal, this.GetComponent<Attack>());
            target.GetComponent<Health>().Heal(heal);
        }             
    }

    private GameObject FindTarget(List<GameObject> list)
    {
        target = list[0];
        howFarFromFull = GetComponent<Info>().hp - GetComponent<Health>().hp;
        foreach (GameObject c in list)
        {
            if (c.GetComponent<Info>().hp - c.GetComponent<Health>().hp > howFarFromFull)
            {
                target = c;
                howFarFromFull = c.GetComponent<Info>().hp - c.GetComponent<Health>().hp;
            }
        }
        return target;
    }
}
