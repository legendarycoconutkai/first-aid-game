using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardGenerator : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalScoreText;
    public ScoreController sc;
    public PrimarySurveyController psc;

    private int totalScore; 

    void Start()
    {
        scoreText.text = sc.getScore().ToString() + "\r\n" + psc.getBonusScore().ToString() + "\r\n333";
        totalScore = sc.getScore() + psc.getBonusScore() + 333;
        totalScoreText.text = totalScore.ToString() + "\r\nTOP 1\r\nA";
    }

    public int getTotalScore()
    {
        return totalScore;
    }
}
