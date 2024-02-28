using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

      [SerializeField] private float moveSpeed = 5f;
      [SerializeField] private float jumpForce = 5f;
      [SerializeField] private float gravity = 9.81f;

      private CharacterController controller;
      private bool isJumping; 

    // Start is called before the first frame update
    void Start()
    Vector3 foward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        transform.Rotate(new Vector3(0,Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime,0));
        cc.Move(foward * Time.deltaTime);
    {
     controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

       /*Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;        
       moveDirection = move * moveSpeed * Time.deltaTime;*/

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
           forward.y -= gravity * Time.deltaTime;
       }/* else {
           forward.y = 0f;
       }*/

       if(Input.GetButtonDown("Jump") && controller.isGrounded)  // conditions for jumping
            isJumping = true;
      
       if (isJumping)   // jumping
       {
           forward.y = jumpForce;
           isJumping = false;
       } 
    controller.Move(moveDirection * Time.deltaTime);  
    }
}