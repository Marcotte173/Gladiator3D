using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Control : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;
    float distance;
    

    // Start is called before the first frame update
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        target = GetComponent<Target>().target;
        if (target != null) Decision();
    }

    private void Decision()
    {
        transform.LookAt(target.transform);
        agent.SetDestination(target.transform.position);
        distance = Vector3.Distance(agent.transform.position, target.transform.position);
        if (distance <= GetComponent<Info>().range)
        {
            agent.speed = 0;
            GetComponent<Attack>().Go(target.GetComponent<Control>());
        }
        else
        {
            GetComponent<Attack>().timer = GetComponent<Attack>().attackSpeed;
            agent.speed = 3;
        }
    }
}
