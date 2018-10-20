using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject obstacle;
    public float nextSpawn;
    public int obstacleCount;
    public int currentCount;
    public float spawnWait = 10;
    public float spawnTime = 2.5F;
    public Transform obstacleSpawner;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentCount >= obstacleCount)
        {
            currentCount = 0;
            nextSpawn = spawnWait;
        }

        nextSpawn -= Time.deltaTime;

        if (nextSpawn <= 0)
        {
            Instantiate(obstacle, obstacleSpawner.position, obstacleSpawner.rotation);
            nextSpawn = spawnTime;
            currentCount++;
        }
    }
}
