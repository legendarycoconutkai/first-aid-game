using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextLanguageManager : MonoBehaviour
{
    public string englishText;
    public string indoText;
    //public TextMeshProUGUI text;

    void Update()
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            this.GetComponentInChildren<Text>().text = englishText;
        }
        else
        {
            this.GetComponentInChildren<Text>().text = indoText;
        }
    }
}
