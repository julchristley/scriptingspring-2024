using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public  GameObject gameOverText;

    public AudioClip endSound;
    private AudioSource endAudio;
    private bool hasEnded;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        hasEnded = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        endAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && !hasEnded)
        {
            hasEnded = true; // keeps audio from repeating frames (sounds horrific btw. like a broken warning alarm.)
            EndGame();
        }
        else if (!isGameOver)
            gameOverText.gameObject.SetActive (false);  // UI text hidden
    }

    public void EndGame()
    {
        if (hasEnded)
        { 
            // text and sound goes off, time stops
            Debug.Log("hasEnded is true");
            gameOverText.gameObject.SetActive(true);
            endAudio.PlayOneShot(endSound, 1.0f);
            Time.timeScale = 0; // freezes time
        }
        
    }
}
