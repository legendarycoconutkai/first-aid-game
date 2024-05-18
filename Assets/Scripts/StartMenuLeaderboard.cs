using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartMenuLeaderboard : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;


    public List<int> dummyNumberList;
    public List<string> dummyNameList;
    public List<int> dummyScoreList;

    //public List<int> realNumberList;
    //public List<string> realNameList;
    //public List<int> realScoreList;



    void Start()
    
    {
       // realNumberList = PassDataToStartMenu.numberList;
       // realNameList = PassDataToStartMenu.nameList;
       // realScoreList = PassDataToStartMenu.scoreList;
        dummyNumberList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        dummyNameList = new List<string> { "NICHOLAS", "JENNIFER", "IKUN", "JOHN", "JETCHOO", "KENNY", "GWEN" };
        dummyScoreList = new List<int> { 8000, 8500, 7000, 6000, 5000, 5500, 4000 };

        if (PassDataToStartMenu.nameList == null)
        {
            foreach (int number in dummyNumberList)
            {
                numberText.text += number + ".\n";
            }

            foreach (string name in dummyNameList)
            {
                nameText.text += name + "\n";
            }

            foreach (int score in dummyScoreList)
            {
                scoreText.text += score + "\n";
            }
        }

        else
        {
            foreach (int number in PassDataToStartMenu.numberList)
            {
                numberText.text += number + ".\n";
            }

            foreach (string name in PassDataToStartMenu.nameList)
            {
                nameText.text += name + "\n";
            }

            foreach (int score in PassDataToStartMenu.scoreList)
            {
                scoreText.text += score + "\n";
            }
        }
    }
}
