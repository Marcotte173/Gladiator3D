using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<GameObject> teamA;
    public List<GameObject> teamB;
    public List<AddToNetworkList> networkList;   

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (AddToNetworkList a in networkList) if (a == null) networkList.Remove(a);        
    }
}
