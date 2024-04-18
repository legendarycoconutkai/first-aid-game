using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardGenerator : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalScoreText;
    public ScoreboardGenerator sbg;

    private int totalScore;

    void Start()
    {
        totalScore = sbg.getTotalScore();
        nameText.text = "1. SAM";
        scoreText.text = totalScore.ToString();
        totalScoreText.text = totalScore.ToString() + "\r\nTOP 1\r\nA";
    }
}
