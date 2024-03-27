using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //playermovement
    public float speed = 4.0f; 
    public float horizontalInput;
    public float verticalInput;
    private Rigidbody playerRb;

    //player constraints
    public float xRange = -9.0f;

    //projectiles
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // linking Rigidbody component
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // getting player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
        // running functions
        MovePlayer();
        ConstrainPlayerPosition();

        //launch projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
          Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
     }

    void MovePlayer()
    {
         // applying movement through Rigidbody
         playerRb.AddForce(Vector3.forward * speed *  verticalInput);
         playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void ConstrainPlayerPosition()
    {
        // constraining player position
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}