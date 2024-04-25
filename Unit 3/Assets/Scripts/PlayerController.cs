using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] private float gravityModifier;

    public bool isOnGround = true;
    [SerializeField] float jumpForce;
    private Vector3 jump;
    public bool isCrouching = false;

    public float xRange = 11.5f;
    public float zRange = 11.5f;

    [SerializeField] public float speed = 8.0f;
    [SerializeField] float resetSpeed = 8.0f;
    [SerializeField] float sprintSpeed = 12.0f;
    [SerializeField] float crouchSpeed = 4.0f;
    private float moveSpeed;

    // for crouching
    private Vector3 defaultColliderSize;
    private Vector3 defaultColliderCenter;
    
    public float mouseSpeed = 5.0f;
    public float mouseX;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        jump = new Vector3(0.0f, 1.0f, 0.0f);

        // for crouching
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
        jumping(); 
        ConstrainPlayerPosition();
        Crouch();
        mouseRotate();       
    }


    void MovePlayer()
    {
       if (Input.GetKey(KeyCode.LeftShift) && !isCrouching)
         {
           moveSpeed = sprintSpeed;
         }
       else
       {
         moveSpeed = speed;
       }
          Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;
          playerRb.AddForce(movement * moveSpeed, ForceMode.Acceleration);
    }

    void jumping()
    {
      if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isCrouching)
      {
        playerRb.AddForce(jump * jumpForce, ForceMode.Impulse);
        isOnGround = false;
      }
    }

    // allows for jumping conditional isOnGround
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

    void Crouch()
    {
      if (Input.GetKeyDown(KeyCode.LeftControl) && !isCrouching)
      {
          isCrouching = true;
          speed = crouchSpeed;

          // changes box collider size, imitates crouching
          BoxCollider collider = GetComponent<BoxCollider>();
          collider.size = new Vector3(collider.size.x, collider.size.y / 2.0f, collider.size.z);
          collider.center = new Vector3(collider.center.x, collider.center.y / 2.0f, collider.center.z);
      }
      
       else if (Input.GetKeyUp(KeyCode.LeftControl) && isCrouching)
      {
          isCrouching = false;
          speed = resetSpeed; // stuck on crouchSpeed without this

          // reseting collider size to original/not crouching
          BoxCollider collider = GetComponent<BoxCollider>();
          collider.size = defaultColliderSize;
          collider.center = defaultColliderCenter;
      }
    }

    void mouseRotate()
    {
      mouseX = Input.GetAxis("Mouse X");
      Vector3 rotation = new Vector3(0, mouseX * mouseSpeed, 0);
      transform.Rotate(rotation);
    }
}