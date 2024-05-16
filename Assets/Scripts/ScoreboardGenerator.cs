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
    public LeaderboardController lbc;
    void Start()
    {
        if (lbc == null)
        {
            Debug.Log("LeaderboardController reference is null!");
        }
      
        scoreText.text = sc.getScore().ToString() + "\r\n" + psc.getBonusScore().ToString() + "\r\n333";

        totalScoreText.text = lbc.getTotalScore().ToString() + "\r\nTOP" + lbc.getRanking().ToString() + "\r\n" + lbc.getGrade().ToString();

       
    }

    
}
