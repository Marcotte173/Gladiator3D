using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{    
    public Slider healthBar;
    public int hp;
    void Start()
    {
        hp = GetComponent<Info>().hp;
        healthBar.value = healthBar.maxValue = hp;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        healthBar.value = hp;
        if (hp <= 0)
        {
            if (GetComponent<Info>().team == "A") GameManager.instance.teamA.Remove(gameObject);
            else if (GetComponent<Info>().team == "B") GameManager.instance.teamB.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    public void Heal(int heal)
    {
        hp += heal;
        healthBar.value = hp;
        hp = (hp > GetComponent<Info>().hp) ? GetComponent<Info>().hp : hp;
    }
}
