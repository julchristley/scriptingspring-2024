using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

      [SerializeField] private float moveSpeed = 5f;
      [SerializeField] private float jumpForce = 5f;
      [SerializeField] private float gravity = 9.81f;

      private CharacterController controller;
      private Vector3 moveDirection;
      private bool isJumping; 

    // Start is called before the first frame update
    void Start()
    {
     controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      if(Input.GetKey(KeyCode.UpArrow))
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
      
      if(Input.GetKey(KeyCode.DownArrow))
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

      if(Input.GetKey(KeyCode.LeftArrow))
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
      
      if(Input.GetKey(KeyCode.RightArrow))
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
      
       if(!controller.isGrounded)  //gravity
       {  
         //  moveDirection.y -= gravity * Time.deltaTime;
         transform.Translate(Vector3.down * gravity * Time.deltaTime);
       }else {
           moveDirection.y = 0f;
       }

       if(Input.GetButtonDown("Jump") && controller.isGrounded)  // conditions for jumping
       isJumping = true;
      
       if (isJumping)   // jumping
       {
           moveDirection.y = jumpForce;
           isJumping = false;
       } 
    controller.Move(moveDirection * Time.deltaTime);
    }
}