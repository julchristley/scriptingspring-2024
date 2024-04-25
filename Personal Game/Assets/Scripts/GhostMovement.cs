using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    [SerializeField] float xRange = -9.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        ConstrainGhostPosition();
    }

        void ConstrainGhostPosition()
    {
      // constraining Ghost position
      if (transform.position.x < xRange)
      {
       transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
    }
}
