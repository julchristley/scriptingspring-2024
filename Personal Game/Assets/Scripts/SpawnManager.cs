using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject ghostPrefab ; 

    //where to spawn
    [SerializeField] float spawnPosX = -8.0f;
    [SerializeField] float spawnPosY = 0.6f;
    [SerializeField] float spawnPosMinZ = -3.8f;
    [SerializeField] float spawnPosMaxZ = -5.8f;

    public int waveNumber = 2;
    public int ghostCount;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGhostWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        // finding Ghost Prefab
        ghostCount =  GameObject.FindGameObjectsWithTag("Ghost").Length;

        if (ghostCount == 0)
        {
            waveNumber ++;
            SpawnGhostWave(waveNumber);
        }
    }

    void SpawnGhostWave(int ghostsToSpawn)
    {
      for (int i = 0; i < ghostsToSpawn; i++)
      {
       Instantiate(ghostPrefab, GenerateSpawnPosition(), ghostPrefab.transform.rotation);
      }
    }

    private Vector3 GenerateSpawnPosition()
    {

       float spawnPosZ = Random.Range(spawnPosMinZ, spawnPosMaxZ);
       Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

       return randomPos;
    }
}