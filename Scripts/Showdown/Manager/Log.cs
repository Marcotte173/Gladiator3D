using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public List<GameObject> teamA;
    public List<GameObject> teamB;
    // Start is called before the first frame update
    void Start()
    {
        if (TeamList.teamA.Count > 0)
        {
            foreach (GameObject g in TeamList.teamA)
            {
                teamA.Add(g);
            }
        }
        if (TeamList.teamB.Count > 0)
        {
            foreach (GameObject g in TeamList.teamB)
            {
                teamB.Add(g);
            }
        }
    }
}
