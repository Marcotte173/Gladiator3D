using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToNetworkList : MonoBehaviour
{
    private void Awake()
    {
        if (!GameManager.instance.networkList.Contains(this))
        {
            GameManager.instance.networkList.Add(this);
        }
        if (GameManager.instance.networkList[0] == this)
        {
            transform.position = new Vector3(4, transform.position.y, 1);            
        }
        else if (GameManager.instance.networkList[1] == this)
        {
            transform.position = new Vector3(4, transform.position.y, 7);
        }
    }
}
