using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowBounds = -10.0f;
    // Start is called before the first frame update
    
    void Awake()
    {
       // restarts update method
       Time.timeScale = 1;
    }
    
    void Start()
    {
        
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
            Debug.Log("Game Over!");
            Destroy(gameObject);
            // stops the player from doing anything
            Time.timeScale = 0;
        }
    }
}
