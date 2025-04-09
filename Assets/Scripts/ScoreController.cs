using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private int currentScore = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    public void AddScore(int score)
    {
        currentScore += score;
        currentScore = Mathf.Max(0, currentScore);
        UpdateScoreUI();
    }

    public void RemoveScore(int score)
    {
        currentScore -= score;
        currentScore = Mathf.Max(0, currentScore);
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {

        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }
}
