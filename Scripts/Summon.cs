using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject agent;
    public string team;

    private void Update()
    {
        if (RemoveSetUpBarrier.instance.start)
        {
            agent = Instantiate(agent, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            agent.GetComponent<Info>().team = team;
            Destroy(gameObject);
        }
    }
}
