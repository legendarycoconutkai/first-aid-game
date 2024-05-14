using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuideTextLanguageManager : MonoBehaviour
{
    string[] englishText = new string[] { "Danger", "Response", "Send for help", "Airway", "Breathing", "Circulation" };
    string[] indoText = new string[] { "Danger\n(Bahaya)", "Response\n(Respons)", "Send for help\n(Panggilan Untuk Bantuan)", "Airway\n(Saluran Udara)", "Breathing\n(Pernafasan)", "Circulation\n(Sirkulasi)" };
    public GameObject textObject;
    public TextMeshProUGUI text;
    public bool[] PrimarySurvey = new bool[6];

    public void booleanController(int i)
    {
        PrimarySurvey[i] = true;
        showText(i);
    }

    public void showText(int i)
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            textObject.SetActive(true);
            text.text = englishText[i];
        }
        else
        {
            textObject.SetActive(true);
            text.text = indoText[i];
        }
    }
}
