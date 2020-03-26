using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blades : MonoBehaviour
{
    public List<GameObject> agents;
    public static Blades instance;
    public bool blades2;
    public int blades;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        blades = agents.Count;
        //UpdateUI();
        if (blades > 1)
        {
            blades2 = true;
        }
        else
        {
            blades2 = false;
        }
    }
}