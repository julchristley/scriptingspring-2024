using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        Debug.Log("Score: "+ score);
        scoreText.text = "Score: " + score;
    }
}
