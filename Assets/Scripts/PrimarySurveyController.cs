using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimarySurveyController : MonoBehaviour
{
    public bool[] PrimarySurvey = new bool[6];
    public TextMeshProUGUI[] character;

    private int order = 0;
    public int bonusScore = 0;
    private bool isAllDoneBool = false;

    void Start()
    {
        for (int i = 0; i < PrimarySurvey.Length; i++)
        {
            PrimarySurvey[i] = false;
        }
    }

    public void booleanController(int i)
    {
        PrimarySurvey[i] = true;
        updateGuide();
    }

    private void updateGuide()
    {
        for (int i = 0; i < PrimarySurvey.Length; i++)
        {
            if (PrimarySurvey[i] && !isAllDoneBool)
            {
                Debug.Log("Text " + i + " is true");
                character[i].color = Color.white;
                isInOrder(i);
                isAllDoneBool = isAllDone();
            }
        }   
    }

    public int getBonusScore()
    {
        return bonusScore;
    }

    private void isInOrder(int i)
    {
        if (i > order)
        {
            bonusScore += (1000 - ((i - order) * 100));
            order = i;
        }
    }

    private bool isAllDone()
    {
        if (character[0].color == Color.white && character[1].color == Color.white && character[2].color == Color.white && character[3].color == Color.white && character[4].color == Color.white && character[5].color == Color.white)
        {
            bonusScore += 1000;
            return true;
        }   
        else
        {
            return false;
        }
    }
}
