using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target
{
    public static float distance;
    public static float health;
    static List<GameObject> team = new List<GameObject> { };
    static GameObject target = new GameObject();

    internal static GameObject Closest(GameObject agent, bool front)
    {
        if (agent.GetComponent<CharacterInfo>().player) team = TeamList.teamB;
        else team = TeamList.teamA;
        //Target first
        target = team[0];
        //Calculate Distance to target
        distance = Vector3.Distance(agent.transform.position, team[0].transform.position);
        //Check each other in the list
        foreach (GameObject c in team)
        {
            if (c.GetComponent<CharacterInfo>().targetable == false) continue;
            //If the distance to them is shorter
            if (Vector3.Distance(agent.transform.position, c.transform.position) < distance)
            {
                //They are the target, new distance
                target = c;
                distance = Vector3.Distance(agent.transform.position, c.transform.position);
            }
        }
        if (front) return target.GetComponent<CharacterInfo>().front;
        else return target.GetComponent<CharacterInfo>().back;        
    }

    internal static GameObject Farthest(GameObject agent, bool front)
    {
        if (agent.GetComponent<CharacterInfo>().player) team = TeamList.teamB;
        else  team = TeamList.teamA;
        //Target first
        target = team[0];
        //Calculate Distance to target
        distance = Vector3.Distance(agent.transform.position, team[0].transform.position);
        //Check each other in the list
        foreach (GameObject c in team)
        {
            if (c.GetComponent<CharacterInfo>().targetable == false) continue;
            //If the distance to them is farthest  
            if (Vector3.Distance(agent.transform.position, c.transform.position) > distance)
            {
                //They are the target, new distance
                target = c;
                distance = Vector3.Distance(agent.transform.position, c.transform.position);
            }
        }
        if (front) return target.GetComponent<CharacterInfo>().front;
        else return target.GetComponent<CharacterInfo>().back;
    }

    internal static GameObject Weakest(GameObject agent, bool front)
    {
        if (agent.GetComponent<CharacterInfo>().player) team = TeamList.teamB;
        else team = TeamList.teamA;
        //Target first
        target = team[0];
        //Calculate Health of Target
        health = team[0].GetComponent<CharacterInfo>().maxHP.value;
        //Check each other in the list
        foreach (GameObject c in team)
        {
            if (c.GetComponent<CharacterInfo>().targetable == false) continue;
            //If the health is smaller
            if (c.GetComponent<CharacterInfo>().maxHP.value < health)
            {
                //They are the target, new health
                target = c;
                health = c.GetComponent<CharacterInfo>().maxHP.value;
            }
        }
        if (front) return target.GetComponent<CharacterInfo>().front;
        else return target.GetComponent<CharacterInfo>().back;
    }
    internal static GameObject Strongest(GameObject agent, bool front)
    {
        if (agent.GetComponent<CharacterInfo>().player) team = TeamList.teamB;
        else team = TeamList.teamA;
        //Target first
        target = team[0];
        //Calculate Health of Target
        health = team[0].GetComponent<CharacterInfo>().maxHP.value;
        //Check each other in the list
        foreach (GameObject c in team)
        {
            if (c.GetComponent<CharacterInfo>().targetable == false) continue;
            //If the health is smaller
            if (c.GetComponent<CharacterInfo>().maxHP.value > health)
            {
                //They are the target, new health
                target = c;
                health = c.GetComponent<CharacterInfo>().maxHP.value;
            }
        }
        if (front) return target.GetComponent<CharacterInfo>().front;
        else return target.GetComponent<CharacterInfo>().back;
    }
}
