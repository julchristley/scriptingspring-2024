using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int scoreToGive = 5;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
	    // destroys game object and the other game object it hits
        if (!other.gameObject.CompareTag("Pickup"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Lazer"))
        {
            Debug.Log("scoring??");
            // increase score
            scoreManager.IncreaseScore(scoreToGive);
        }
    }
}
