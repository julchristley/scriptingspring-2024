using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    private Button startButton;
    private Button quitButton;

    public AudioClip startSound;
    public AudioClip quitSound;

    private AudioSource startAudio;
    private AudioSource quitAudio;

    // Start is called before the first frame update
    void Start()
    {
         startAudio = GetComponent<AudioSource>();
         quitAudio = GetComponent<AudioSource>();

         GameObject startButtonGO = GameObject.Find("StartButton");
         startButton = startButtonGO.GetComponent<Button>();
         startButton.onClick.AddListener(StartSound);
 
         GameObject quitButtonGO = GameObject.Find("QuitButton");
         quitButton = quitButtonGO.GetComponent<Button>();
         quitButton.onClick.AddListener(QuitSound);
    }

    void StartSound()
    {
        startAudio.PlayOneShot(startSound, 1.0f);
    }

    void QuitSound()
    {
        quitAudio.PlayOneShot(quitSound, 1.0f);
    }
}
