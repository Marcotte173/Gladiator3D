using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [SerializeField]
    HealthStatus body;
    [SerializeField]
    HealthStatus armor;
    public void Go(int damage)
    {
        if (armor.hp > 0 && armor.hp > damage) armor.hp -= damage;
        else if (armor.hp > 0 && armor.hp < damage)
        {
            body.hp -= (damage - armor.hp);
            armor.hp -= armor.hp;            
        }
        else body.hp -= damage;
    }

    public void OnMouseDown()
    {
        Go(2);
    }
}