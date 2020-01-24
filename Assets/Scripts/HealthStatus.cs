using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    public int hp;
    public int maxHp;
    public bool destroyed;
    public bool undamaged;
    public bool damaged;
    public bool severelyDamaged;
    public string Status;
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            destroyed = true;
            undamaged = false;
            damaged = false;
            severelyDamaged = false;
        }
        else if (hp == maxHp)
        {
            destroyed = false;
            undamaged = true;
            damaged = false;
            severelyDamaged = false;
        }
        else if (hp < maxHp && (hp == 1 || hp == 2))
        {
            destroyed = false;
            undamaged = false;
            damaged = false;
            severelyDamaged = true;
        }
        else
        {
            destroyed = false;
            undamaged = false;
            damaged = true;
            severelyDamaged = false;
        }
        Status = (maxHp == 0) ? "None" : (destroyed) ? "Destroyed" : (damaged) ? "Damaged" : (severelyDamaged) ? "Severely Damaged" : "Undamaged";
    }
}
