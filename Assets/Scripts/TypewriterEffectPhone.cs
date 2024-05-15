using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterEffectPhone : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject[] buttons;
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
            StartCoroutine(Typewriter("\"There is a "));
            for (int j = 0; j < engText[i].Length; j++)
            {
                buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = engText[i][j];
            }
        }
        else
        {
            StartCoroutine(Typewriter("\"There is a "));
            for (int j = 0; j < indoText[i].Length; j++)
            {
                buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = indoText[i][j];
            }
        }

        i++;
    }

    public void showTextSub(string t)
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            if (i == 1)
            {
                StartCoroutine(Typewriter(t + " at "));
                for (int j = 0; j < engText[i].Length; j++)
                {
                    buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = engText[i][j];
                }
            }

            if (i == 2)
            {
                StartCoroutine(Typewriter(t + " with a total of "));
                for (int j = 0; j < engText[i].Length; j++)
                {
                    buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = engText[i][j];
                }
            }  

            if (i == 3)
            {
                StartCoroutine(Typewriter(t + " casualty(s)."));
            }

        }
        else
        {
            if (i == 1)
            {
                StartCoroutine(Typewriter(t + " di "));
                for (int j = 0; j < indoText[i].Length; j++)
                {
                    buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = indoText[i][j];
                }
            }

            if (i == 2)
            {
                StartCoroutine(Typewriter(t + " dengan total "));
                for (int j = 0; j < indoText[i].Length; j++)
                {
                    buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = indoText[i][j];
                }
            }

            if (i == 3)
            {
                StartCoroutine(Typewriter(t + " orang."));
            }

            for (int j = 0; j < indoText[i].Length; j++)
            {
                buttons[j].GetComponentInChildren<TextMeshProUGUI>().text = indoText[i][j];
            }
        }

        i++;
    }

    IEnumerator Typewriter(string t)
    {
        foreach (char c in t)
        {
            text.text += c;
            yield return new WaitForSeconds(delay);
        }
    }
}
