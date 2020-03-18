using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public Slider energyBar;
    public float energy;
    public float energyGain;
    // Start is called before the first frame update
    void Start()
    {
        energyBar.maxValue = GetComponent<Info>().energy;
        energyBar.value = energy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Info>().energy > 0 && GetComponent<Target>().target != null)
        {
            if (GetComponent<Stealth>() != null && GetComponent<Stealth>().stealthed) { }
            else
            {
                energyBar.value = energy += energyGain * Time.deltaTime;
                if (energy >= GetComponent<Info>().energy)
                {
                    energyBar.value = energy = 0;
                    if (GetComponent<Fireball>() != null) GetComponent<Fireball>().Cast(GetComponent<Target>().target);
                    if (GetComponent<Stealth>() != null) GetComponent<Stealth>().Cast(GetComponent<Target>().target);
                    if (GetComponent<Heal>() != null) GetComponent<Heal>().Cast();
                    if (GetComponent<Backstab>() != null) GetComponent<Backstab>().Cast(GetComponent<Target>().target);
                }
            }            
        }        
    }
}
