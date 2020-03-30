using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack 
{
    public static void Go(GameObject attacker, GameObject defender)
    {
        //Get damage and penetration
        float damage = attacker.GetComponent<CharacterInfo>().physicalDamage.value;
        float pen = attacker.GetComponent<CharacterInfo>().physicalPenetration.value;
        //If attempt to hit succeeds;
        if (AttemptToHit(defender.GetComponentInParent<CharacterInfo>().dodge.value))
        {
            //Then attempt to crit. If that succeeds
            if (AttemptToCrit(attacker.GetComponent<CharacterInfo>().crit.value))
            {
                //Double damage, defender takes it
                damage *= 2;
                defender.GetComponentInParent<Health>().TakePhysicalDamage(damage, pen);
            }
            else 
            {
                //If not, regular damage
                defender.GetComponentInParent<Health>().TakePhysicalDamage(damage , pen );
            }
        }
        //If you don't hit, dodge!
        else {  }        
    }

    public static void Go(GameObject attacker, List<GameObject> defenders)
    {
        //Get damage and penetration
        float damage = attacker.GetComponent<CharacterInfo>().physicalDamage.value;
        float pen = attacker.GetComponent<CharacterInfo>().physicalPenetration.value;
        //If attempt to hit succeeds;
        foreach(GameObject defender in defenders)
        {
            if (AttemptToHit(defender.GetComponentInParent<CharacterInfo>().dodge.value))
            {
                //Then attempt to crit. If that succeeds
                if (AttemptToCrit(attacker.GetComponent<CharacterInfo>().crit.value))
                {
                    //Double damage, defender takes it
                    damage *= 2;
                    defender.GetComponentInParent<Health>().TakePhysicalDamage(damage, pen);
                }
                else
                {
                    //If not, regular damage
                    defender.GetComponentInParent<Health>().TakePhysicalDamage(damage, pen);
                }
            }
            //If you don't hit, dodge!
            else { }
        }        
    }

    //Roll a 100 against attacker's crit value;
    private static bool AttemptToCrit(float crit)
    {
        return (Random.Range(1, 100) < crit);
    }

    //Roll a 100 against defender's dodge
    private static bool AttemptToHit(float dodge)
    {
        return (Random.Range(1, 100) > dodge);
    }
}