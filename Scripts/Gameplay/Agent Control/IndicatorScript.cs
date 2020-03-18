using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{
    public Material teamA;
    public Material teamB;
    
    void Start()
    {
        if (GetComponentInParent<Info>().team == "A") GetComponent<Renderer>().material = teamA;
        else if (GetComponentInParent<Info>().team == "B") GetComponent<Renderer>().material = teamB;
    }
}
