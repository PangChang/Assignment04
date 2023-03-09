using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public static float spawnDelay;
    public float spawnTime = 0.3f;

    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;


    void Start()
    {
 
    }

    void Update()
    {
        spawnTime = DataManager.spawnDelay;
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnTime;
        }

    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }

}
