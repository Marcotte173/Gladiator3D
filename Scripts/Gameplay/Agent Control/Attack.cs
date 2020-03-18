using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Attack : MonoBehaviour
{
    public bool ranged;
    int damage;
    internal float attackSpeed;
    internal float timer;
    void Start()
    {
        timer = attackSpeed = GetComponent<Info>().attackSpeed;
        damage = GetComponent<Info>().damage;
    }

    internal void Go(Control target)
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (ranged) GetComponent<Shoot>().Go();
            else if (Roll() <= GetComponent<Info>().hit - target.GetComponent<Info>().defence)
            {
                if (Roll() <= GetComponent<Info>().crit)
                {
                    target.GetComponent<CombatInfoUI>().Crit(damage, this);
                    target.GetComponent<Health>().TakeDamage(damage);                    
                }
                else
                {
                    target.GetComponent<CombatInfoUI>().Hit(damage, this);
                    target.GetComponent<Health>().TakeDamage(damage);                    
                }
            }
            else target.GetComponent<CombatInfoUI>().Miss();
            timer = attackSpeed;
        }        
    }

    int Roll()
    {
        return Random.Range(1, 100);
    }
}
