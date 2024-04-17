using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimarySurveyController : MonoBehaviour
{
    public bool[] PrimarySurvey = new bool[6];
    
    public TextMeshProUGUI[] character;

    void Start()
    {
        for (int i = 0; i < PrimarySurvey.Length; i++)
        {
            PrimarySurvey[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PrimarySurvey[0])
        {
            character[0].color = Color.white;
        }
        else if (PrimarySurvey[1])
        {
            character[1].color = Color.white;
        }
        else if (PrimarySurvey[2])
        {
            character[2].color = Color.white;
        }
        else if (PrimarySurvey[3])
        {
            character[3].color = Color.white;
        }
        else if (PrimarySurvey[4])
        {
            character[4].color = Color.white;
        }
        else if (PrimarySurvey[5])
        {
            character[5].color = Color.white;
        }   
    }

    public void booleanController(int i)
    {
        PrimarySurvey[i] = true;
    }
}
