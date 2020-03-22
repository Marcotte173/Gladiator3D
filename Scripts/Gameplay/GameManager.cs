using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<GameObject> teamA;
    public List<GameObject> teamB; 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        for (int i = 0; i < GameInfo.summon.Count; i++)
        {
            GameObject agent = Instantiate(GameInfo.summon[i], new Vector3(-1 + i, 0, 2), Quaternion.identity);
        }
    }
}
