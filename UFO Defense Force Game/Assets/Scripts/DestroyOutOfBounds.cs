using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowBounds = -10.0f;
    public GameManager gameManager;

    void Awake()
    {
       // restarts update method
       Time.timeScale = 1;
    }
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }  
        else if (transform.position.z < lowBounds)
        {
            Destroy(gameObject);
             if (gameObject.CompareTag("UFO"))
             {
             Debug.Log("Game Over!");
              // stops the player from doing anything
              Time.timeScale = 0;
              gameManager.isGameOver = true;
             }
        }
    }
}
