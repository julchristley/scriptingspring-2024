using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 8.0f;
    private Rigidbody playerRb;

    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    private Vector3 jump;

    public float xRange = 11.5f;
    public float zRange = 11.5f;
    public float sprintSpeed = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;

        jump = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        ConstrainPlayerPosition();
        Sprint();
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
        if (Input.GetKey(KeyCode.LeftShift))
        {
         // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * sprintSpeed);
         Vector3 sprinting = new Vector3(horizontalInput * sprintSpeed, 0f, verticalInput * sprintSpeed);
         playerRb.velocity = sprinting;
        }
    }
}