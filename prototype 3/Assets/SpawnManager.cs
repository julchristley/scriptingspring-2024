using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 1;
    private float repeatRate = 2;

    // references PlayerController script
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        // setting playerControllerScript to be the actual playerController script by using Player object
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
       
        // calls SpawnObstacle and repeats it
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObstacle ()
    {
      if (playerControllerScript.gameOver == false)
      {
       // spawns obstacle
      Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
      }

    }
}
