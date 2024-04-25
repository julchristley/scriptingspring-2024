using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pickupPrefab;
    public float spawnRange = 20.0f;
    private float startDelayPickup = 5;
    private float repeatRate = 8;
   
    public GameObject [] ufoPrefabs; // array for UFO ships
    [SerializeField] float spawnRangeX = 20f;
    [SerializeField] float spawnPosZ = 20f;

    private float startDelay = 2f;
    [SerializeField] float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPickup", startDelayPickup, repeatRate);
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //randomizes spawn location
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); // randomizes array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); // spawns random UFO in random location
    }

    private Vector3 GenerateSpawnPosition()
    {
        // randomly generates spawn position
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, 15);

        return randomPos;
    }

    void spawnPickup()
    {
        Instantiate(pickupPrefab, GenerateSpawnPosition(), pickupPrefab.transform.rotation);
    }
}
