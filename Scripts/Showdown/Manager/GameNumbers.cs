using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameNumbers : MonoBehaviour
{
    [SerializeField]
    float energyGain;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float lookSpeed;
    // Update is called once per frame
    void Update()
    {
        foreach(GameObject g in TeamList.teamA)
        {
            if (g.GetComponent<Energy>()) g.GetComponent<Energy>().energyGain = energyGain;
            g.GetComponent<AIManager>().moveSpeed = moveSpeed;
            g.GetComponent<AIManager>().lookSpeed = lookSpeed;
        }
        foreach (GameObject g in TeamList.teamB)
        {
            if (g.GetComponent<Energy>())g.GetComponent<Energy>().energyGain = energyGain;
            g.GetComponent<AIManager>().moveSpeed = moveSpeed;
            g.GetComponent<AIManager>().lookSpeed = lookSpeed;
        }
        Destroy(gameObject);
    }
}
