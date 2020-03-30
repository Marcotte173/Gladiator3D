using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIManager : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;
    CharacterInfo info;
    float distance;
    float timer;
    float attackspeed;
    internal float moveSpeed;
    internal float lookSpeed;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        info = GetComponent<CharacterInfo>();
        timer = attackspeed = 1 / info.attackSpeed.value;
    }

    private void Update()
    {
        //If game has started, Game isn't over, and character is not stunned
        if (info.canAct)
        {
            //If you don't have a target and a potential target exists, get a target
            if (target == null && TeamList.teamA.Count > 0 && TeamList.teamB.Count > 0) GetTarget();
            //If you have a target, logic
            if (target != null) Logic();
        }         
    }
    void GetTarget()
    {
        //Get the closest target
        target = Target.Closest(this.gameObject, true);
    }

    void Logic()
    {
        //Get distance to your target
        distance = Vector3.Distance(this.gameObject.transform.position, target.transform.position);
        //Set target as destination
        agent.SetDestination(target.transform.position);
        //Turn to face
        LookAt(agent, target.transform.position - agent.transform.position);       
        //If within range, attack
        if (distance < info.range.value * target.GetComponentInParent<CharacterInfo>().size.value) Attack();
        //Otherwise, move to withing range
        else Move();
    }

    private void Move()
    {   
        //Destination is already set, speed is now 2
        agent.speed = moveSpeed;
    }

    private void Attack()
    {
        //speed is now 0
        agent.speed = 0;
        //count down to attack
        timer -= Time.deltaTime;
        //If the timer is at 0
        if (timer <= 0)
        {
            //reset the timer
            timer = attackspeed;            
            //Attack
            if (info.cleave)
            {
                List<GameObject> targets = new List<GameObject> { };
                if (info.player) 
                foreach(GameObject g in TeamList.teamB.ToList())
                {
                        if (Vector3.Distance(this.gameObject.transform.position, g.transform.position) < 1.5f * g.GetComponent<CharacterInfo>().size.value) targets.Add(g);
                        BasicAttack.Go(this.gameObject, targets.ToList());
                }
            }
            else BasicAttack.Go(this.gameObject, target);
        }        
    }
    public void LookAt(NavMeshAgent agent, Vector3 difference)
    {
        //Turn to look at the target
        agent.transform.rotation = Quaternion.RotateTowards(agent.transform.rotation, Quaternion.LookRotation(difference), Time.time * lookSpeed);
    }
}
