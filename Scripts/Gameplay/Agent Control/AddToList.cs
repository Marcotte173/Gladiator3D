using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToList : MonoBehaviour
{
    string team;
    void Start()
    {
        team = GetComponent<Info>().team;
        Add();
    }

    internal void Add()
    {
        if (team == "A" && !GameManager.instance.teamA.Contains(gameObject)) GameManager.instance.teamA.Add(gameObject);
        else if (team == "B" && !GameManager.instance.teamB.Contains(gameObject)) GameManager.instance.teamB.Add(gameObject);
    }
}
