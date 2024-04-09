using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pickupPrefab;
    public float spawnRange = 22.0f;
    private float startDelay = 5;
    private float repeatRate = 8;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnPickup", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
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
