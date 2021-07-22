using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : NewBehaviourScript : MonoBehaviour
{ 


public GameObject CubeEnemy;
public float health;
public float cooldown;


void Start()
{

}


void Update()
{
    cooldown -= Time.detalTime;

    if (CubeEnemy != null)
    {
        if (Vector3.Distance(transform.position, CubeEnemy.transform.position) > 1)
            transform.position = Vector3.MoveTowards(transform.position, CubeEnemy.transform.position, 0.1f);
        else
        {
            if (cooldown <= 0)
            {
                cooldown = 1;
                CubeEnemy.GetComponent<CubeEnemy>().health -= 1

                }


        }
    }

}
if (health <= 0)
    Destroy(gameObject);
}
