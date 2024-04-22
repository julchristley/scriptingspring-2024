using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // movement
    private CharacterController controller;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5.0f;

    // jumping
    public float jumpForce = 5.0f;
    public float gravityModifier = 2.0f;
    public bool isOnGround = true;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        // referencing character controller
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // player input for movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        MovePlayer();

        //jumping
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            moveDirection.y = jumpForce;
            isOnGround = false;
        }
    }
    void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;
        controller.SimpleMove(moveDirection * speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
