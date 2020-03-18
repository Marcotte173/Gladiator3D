using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class Spawn : NetworkBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer == false) return;
        CmdSpawnMyUnit();        
    }

    [Command]
    private void CmdSpawnMyUnit()
    {
        spawn = Instantiate(spawn, transform.position, Quaternion.identity);
        if (GameManager.instance.networkList[0] == GetComponent<AddToNetworkList>()) spawn.GetComponent<Summon>().team = "A";
        else spawn.GetComponent<Summon>().team = "B";
        NetworkServer.Spawn(spawn);
    }
}
