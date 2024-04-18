using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenManualInOtherScene : MonoBehaviour
{
    public GameObject[] manual;

    public void OpenManual()
    {
        GameObject language = GameObject.Find("Language Button");
        bool isEng = language.GetComponent<ManualLanguageController>().getLanguage();

        if (isEng)
        {
            manual[0].SetActive(true);
        }
        else
        {
            manual[1].SetActive(true);
        }
    }
}
