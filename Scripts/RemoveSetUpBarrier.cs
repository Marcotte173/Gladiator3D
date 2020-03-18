using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class RemoveSetUpBarrier : MonoBehaviour
{
    public bool start;
    public GameObject Barrier;
    public static RemoveSetUpBarrier instance;

    private void Start()
    {        
        instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Barrier.activeSelf)
        {
            start = true;
            Destroy(Barrier);
        }
    }
}
