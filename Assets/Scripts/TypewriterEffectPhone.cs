using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterEffectPhone : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject panel;
    public GameObject doneButton;
    public GameObject[] buttons;
    public GameObject[] buttonsText;
    public PrimarySurveyController psc;
    public GuideTextLanguageManager gtlm;

    private string[][] engText = new string[][] {
    new string[] {"Road Traffic Accident", "Electrical Accident", "Workplace Accident"},
    new string[] {"Plantation", "Factory", "Highway"},
    new string[] {"1", "2", "3"}
    };

    private string[][] indoText = new string[][] {
    new string[] {"Road Traffic Accident", "Electrical Accident", "Workplace Accident"},
    new string[] {"Plantation", "Factory", "Highway"},
    new string[] {"1", "2", "3"}
    };

    public float delay = 0.1f;
    private int i;

    private void OnEnable()
    {
        text.text = "";
        i = 0;
        showTextInitial();
    }

    private void showTextInitial()
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            StartCoroutine(Typewriter(("\"There is a "), isEng));
            generateEmptyButton();
        }
        else
        {
            StartCoroutine(Typewriter(("\"There is a "), isEng));
            generateEmptyButton();
        }
    }

    public void showTextSub(string t)
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            if (i == 1)
            {
                StartCoroutine(Typewriter((t + " at "), isEng));
                generateEmptyButton();
            }

            if (i == 2)
            {
                StartCoroutine(Typewriter((t + " with a total of "), isEng));
                generateEmptyButton();
            }  

            if (i == 3)
            {
                StartCoroutine(Typewriter((t + " casualty(s).\""), isEng));
                panel.SetActive(false);
                doneButton.SetActive(true);
                psc.booleanController(2);
                gtlm.booleanController(2);
            }
        }
        else
        {
            if (i == 1)
            {
                StartCoroutine(Typewriter((t + " di "), isEng));
                generateEmptyButton();
            }

            if (i == 2)
            {
                StartCoroutine(Typewriter((t + " dengan total "), isEng));
                generateEmptyButton();
            }

            if (i == 3)
            {
                StartCoroutine(Typewriter((t + " orang.\""), isEng));
                panel.SetActive(false);
                doneButton.SetActive(true);
                psc.booleanController(2);
                gtlm.booleanController(2);
            }
        }
    }

    IEnumerator Typewriter(string t, bool isEng)
    {
        foreach (char c in t)
        {
            text.text += c;
            yield return new WaitForSeconds(delay);
        }

        if (isEng)
        {
            generateEnglishButton();
            i++;
        }
        else
        {
            generateIndoButton();
            i++;
        }
    }

    private void generateEnglishButton()
    {
        activateButtonText();
        for (int j = 0; j < engText[i].Length; j++)
        {
            buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = engText[i][j];
        }
    }

    private void generateIndoButton()
    {
        activateButtonText();
        for (int j = 0; j < engText[i].Length; j++)
        {
            buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = engText[i][j];
        }
    }

    private void generateEmptyButton()
    {
        for (int j = 0; j < buttons.Length; j++)
        {
            buttonsText[j].SetActive(false);
        }
    }

    private void activateButtonText()
    {
        for (int j = 0; j < buttons.Length; j++)
        {
            buttonsText[j].SetActive(true);
        }
    }
}
