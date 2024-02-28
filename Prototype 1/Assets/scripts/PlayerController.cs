using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 20.0f; // initializing speed variable
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //how we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moving the vehicle forward through vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotating the vehicle through vertical input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput *Time.deltaTime);
        //old code to move side to side: transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
