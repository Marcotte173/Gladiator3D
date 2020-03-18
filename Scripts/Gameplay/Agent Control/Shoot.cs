using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public GameObject shootOrigin;

    private void Start()
    {
        projectile = Instantiate(projectile, shootOrigin.transform.position, Quaternion.identity);
        projectile.SetActive(false);
    }
    internal void Go()
    {
        projectile.SetActive(true);
        projectile.transform.position = shootOrigin.transform.position;
        projectile.GetComponent<ProjectileMove>().target = GetComponent<Target>().target;
    }
}
