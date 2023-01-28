using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] Diver;
    private int DiverCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (DiverCount <= 8)
            {
                int randEnemy = Random.Range(0, Diver.Length);
            int randSpawPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(Diver[0], spawnPoints[randSpawPoint].position, transform.rotation);
            DiverCount++;
            }
        }
    }
}
