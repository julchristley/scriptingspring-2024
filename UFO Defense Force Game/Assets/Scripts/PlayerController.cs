using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 16.0f;
    public float xRange = 10.0f;
    public Transform blaster;
    public GameObject lazer;
    public bool hasPickup = false;

    // Update is called once per frame
    void Update()
    {
        // sets horizontalInput to recieve values from player
        horizontalInput = Input.GetAxis("Horizontal");

        // moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // player constraints
        // left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // creates lazerbolt when space bar is pressed
            Instantiate(lazer, blaster.transform.position, lazer.transform.rotation);
        }
    }
        // delete any object that hits the player 
    private void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject);
            if (other.CompareTag("Pickup"))
            {
                hasPickup = true;
                Debug.Log("Pickup collected");
            }
    }
}
