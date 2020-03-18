using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int damage = 4;
    internal void Cast(GameObject target)
    {
        target.GetComponent<CombatInfoUI>().Fireball(damage, this.GetComponent<Attack>());
        target.GetComponent<Health>().TakeDamage(damage);        
    }
}
