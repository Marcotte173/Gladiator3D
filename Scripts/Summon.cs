using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject agent;
    public string team;

    private void Start()
    {
        if (team == "B") transform.rotation = new Quaternion(0, 180, 0, 0);
    }

    private void Update()
    {
        if (RemoveSetUpBarrier.instance.start)
        {
            agent = Instantiate(agent, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            agent.GetComponent<Info>().team = team;
            if (team == "B") agent.GetComponent<Transform>().rotation = new Quaternion(0, 180, 0,0);
            Destroy(gameObject);
        }
    }
}
