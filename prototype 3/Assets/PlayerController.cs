using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // reference to rigidbody
    private Rigidbody playerRb;

    //reference to animator
    private Animator playerAnim;

    //special effects
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    //sound effects
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        // linking components rigidbody, animator, audiosource to this class
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) //!gameOver means gameOver == false, if gameOver is not equal to true
        {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;

        // jumping animation whenever if statement is met
        playerAnim.SetTrigger("Jump_trig");
        dirtParticle.Stop();

        // sound effects when jumping
        playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    // detects collisions
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        dirtParticle.Play();

        // prevents double jumping by recognizing the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        // ends game when colliding with an obstacle
        else if (collision.gameObject.CompareTag("Obstacle")) 
        {
            gameOver = true;
            Debug.Log("Game Over!");

            // death animation
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();

            //Audio 
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
