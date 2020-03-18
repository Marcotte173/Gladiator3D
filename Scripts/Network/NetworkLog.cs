using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetworkLog : MonoBehaviour
{
    void Update()
    {        
        GetComponent<Text>().text = GameManager.instance.networkList.Count.ToString();
    }
}
