using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stealth : MonoBehaviour
{
    List<GameObject> team;
    public GameObject body;
    public bool stealthed;
    public float stealthLength = 1.5f;
    public float timer;
    AddToList add;
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Info>().team == "A") team = GameManager.instance.teamA;
        else if (GetComponent<Info>().team == "B") team = GameManager.instance.teamB;
        add = GetComponent<AddToList>();
        timer = stealthLength;
    }

    // Update is called once per frame
    void Update()
    {
        if (stealthed)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = stealthLength;
                stealthed = false;
                body.SetActive(true);
                add.Add();
            }
        }
    }

    internal void Cast(GameObject target)
    {
        GetComponent<CombatInfoUI>().Stealth();
        stealthed = true;
        team.Remove(gameObject); 
        body.SetActive(false);        
    }
}
