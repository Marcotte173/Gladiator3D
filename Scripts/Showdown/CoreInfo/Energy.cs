using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    internal float maxEnergy;
    internal float energy;
    internal float baseEnergy;
    internal float energyGain;
    Bars bar;
    CharacterInfo info;

    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponentInChildren<Bars>();        
        info = GetComponent<CharacterInfo>();
        energy = baseEnergy = info.energy.value;
        maxEnergy = info.maxEnergy.value;
    }

    void Update()
    {
        if (info.canAct && maxEnergy > 0)
        {
            energy += Time.deltaTime * energyGain;
            if (energy >= maxEnergy)
            {
                energy = baseEnergy;
                Cast();
            }
            bar.SetEnergy(energy / maxEnergy);
        }        
    }

    private void Cast()
    {
        Debug.Log("Casting! " + gameObject.name);
    }
}
