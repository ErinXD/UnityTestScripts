using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        GameObject[] c = GameObject.FindGameObjectsWithTag("Cube");
        for(int i = 0; i < c.Length, i++)
        {
            if (c[i].GetComponent<Cube>().CubeEnemy != null)
                continue;
            int distance = 0;
            if (i == 0)
                distance = 1;
            
            for (int i2 = 0; i2 < c.Length; i2++)
            {
                if (c[i2].GetComponent<Cube>().CubeEnemy != null)
                {
                    continue;
                }

                if (i2 == i) continue;

                if (Vector3.Distance(c[i].transform.position, c[i2].trasform.position) < Vector3.Distance(c[i].transform.position, c[distance].transform.position))
                {
                    distance = i2;
                }

            }

            if (c[distance].GetComponent<Cube>().CubeEnemy == null)
            {

                c[distance].GetComponent<Cube>().CubeEnemy = c[i];
                c[i].GetComponent<Cube>().CubeEnemy = c[distance];
            }


        }
    }
}
