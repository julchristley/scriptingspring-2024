using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    private Rigidbody playerRb;
    public float gravityModifier;

    public bool isOnGround = true;
    public float jumpForce;
    private Vector3 jump;
    public bool isCrouching = false;

    public float xRange = 11.5f;
    public float zRange = 11.5f;

    public float speed = 8.0f;
    public float resetSpeed = 8.0f;
    public float sprintSpeed = 12.0f;
    public float crouchSpeed = 4.0f;

    private Vector3 defaultColliderSize;
    private Vector3 defaultColliderCenter;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        jump = new Vector3(0.0f, 1.0f, 0.0f);

        BoxCollider collider = GetComponent<BoxCollider>();
        defaultColliderSize = collider.size;
        defaultColliderCenter = collider.center;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isCrouching)
        {
            playerRb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        ConstrainPlayerPosition();
        Sprint();
        Crouch();
    }

    void MovePlayer()
    {
      // applying movement through Rigidbody
      playerRb.AddForce(Vector3.forward * speed *  verticalInput);
      playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Obstacle"))
        {
            isOnGround = true;
        }
    }

    void ConstrainPlayerPosition()
    {
      // right
      if (transform.position.x > xRange)
      {
       transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
      // left
      if (transform.position.x < -xRange)
      {
       transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }
      // top
      if (transform.position.z > zRange)
      {
       transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
      }
       // bottom
      if (transform.position.z < -zRange)
      {
       transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
      }
    }

    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift) && !isCrouching)
        {
         Vector3 sprinting = new Vector3(horizontalInput * sprintSpeed, 0f, verticalInput * sprintSpeed);
         playerRb.velocity = sprinting;
        }
    }

    void Crouch()
    {
      if (Input.GetKeyDown(KeyCode.LeftControl) && !isCrouching)
      {
          isCrouching = true;
          speed = crouchSpeed;
          BoxCollider collider = GetComponent<BoxCollider>();
          collider.size = new Vector3(collider.size.x, collider.size.y / 2.0f, collider.size.z);
          collider.center = new Vector3(collider.center.x, collider.center.y / 2.0f, collider.center.z);
      }
      
       else if (Input.GetKeyUp(KeyCode.LeftControl) && isCrouching)
      {
          isCrouching = false;
          speed = resetSpeed;
          BoxCollider collider = GetComponent<BoxCollider>();
          collider.size = defaultColliderSize;
          collider.center = defaultColliderCenter;
      }
    }
}