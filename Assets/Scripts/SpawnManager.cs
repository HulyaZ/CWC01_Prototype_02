using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    float spawnRangeX = 20;
    float spawnPosZ = 30;

    float startDelay = 1;
    

    void Start()
    {
        float spawnInterval = Random.Range(1.2f, 1.8f);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }
}
