using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartMenuLanguageManager : MonoBehaviour
{
    public string englishText;
    public string indoText;
    public TextMeshProUGUI text;

    void Update()
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            text.text = englishText;
        }
        else
        {
            text.text = indoText;
        }
    }
}
