using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProjectileMove : MonoBehaviour
{
    public GameObject target;
    public float distance;
    public int damage;
    public int speed;
    public float timeToDeactivate;
    float timer;

    private void Start()
    {
        timer = timeToDeactivate;
    }
    private void Update()
    {
        if (target != null)
        {
            timer -= Time.deltaTime;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            distance = Vector3.Distance(this.transform.position, target.transform.position);
            if (distance < .1f)
            {
                target.GetComponent<Health>().TakeDamage(damage);
                gameObject.SetActive(false);
            }
            else if (timeToDeactivate <= 0)
            {
                gameObject.SetActive(false);
                timer = timeToDeactivate;
            }
        }        
    }
}
