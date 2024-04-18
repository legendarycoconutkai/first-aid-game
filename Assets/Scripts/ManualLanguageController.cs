using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManualLanguageController : MonoBehaviour
{
    public GameObject[] manual;
    public TextMeshProUGUI text;

    private bool isEng = true;

    public void ChangeLangauge()
    {
        if (!isEng)
        {
            isEng = true;
            text.text = "EN";
        }
        else
        {
            isEng = false;
            text.text = "ID";
        }
    }

    public void OpenManual()
    {
        if (isEng)
        {
            manual[0].SetActive(true);
        }
        else
        {
            manual[1].SetActive(true);
        }
    }

    public bool getLanguage()
    {
        return isEng;
    }
}
