using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public ScoreManager scoreManager;

    public int scoreToGive = 5;

    public AudioClip destroySound;
    private AudioSource destroyAudio;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        destroyAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Lazer"))
        {
            destroyAudio.PlayOneShot(destroySound, 1.0f);
            StartCoroutine(DestroyAfterSound());
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(other.gameObject);
        }

        // this makes sure the UFO sticks around long enough to play the destroySound effect.
        IEnumerator DestroyAfterSound()
        {
            yield return new WaitForSeconds(destroySound.length * 0.8f);
            Destroy(gameObject);  // destroys UFO
        }
    }
}
