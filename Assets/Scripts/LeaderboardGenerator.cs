using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//this is show the leaderboard page but only the user with the real mark need to modify, putting and display an arrayList
public class LeaderboardGenerator : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalScoreText;
    public LeaderboardController lbc;

    void Start()
    {
        
        foreach (int number in lbc.getNumberList())
        {
            numberText.text += number + ".\n";
        }

        foreach (string name in lbc.getNameList())
        {
            nameText.text += name + "\n";
        }

        foreach (int score in lbc.getScoreList())
        {
            scoreText.text += score + "\n";
        }

        
        totalScoreText.text = lbc.getTotalScore().ToString() + "\r\nTOP"+ lbc.getRanking().ToString() + "\r\n" + lbc.getGrade().ToString();

    }

    
}
