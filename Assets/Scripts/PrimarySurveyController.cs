using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimarySurveyController : MonoBehaviour
{
    public bool[] PrimarySurvey = new bool[6];
    public TextMeshProUGUI[] character;

    private int order = 0;
    private int bonusScore = 0;

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
            if (PrimarySurvey[i])
            {
                character[i].color = Color.white;
                isInOrder(i);
                isAllDone();
            }
        }   
    }

    private int getBonusScore()
    {
        return bonusScore;
    }

    private void isInOrder(int i)
    {
        if (i > order)
        {
            bonusScore += (1000 - (i - order) * 100);
        }

        order = i;
    }

    private void isAllDone()
    {
        if (PrimarySurvey[0] && PrimarySurvey[1] && PrimarySurvey[2] && PrimarySurvey[3] && PrimarySurvey[4] && PrimarySurvey[5])
        {
            bonusScore += 1000;
        }   
    }
}
