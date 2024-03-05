using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) // if object is above 30, destroys object
        {
          Destroy(gameObject); 
        } else if (transform.position.z < lowerBound)  // if object is below -10, destroys object and displays 'game over!'
        {
        Debug.Log("Game Over!");
        Destroy(gameObject);
        }
    }
}
