using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenDropdownController : MonoBehaviour
{
    public GameObject engDropdown;
    public GameObject indoDropdown;
    public SceneChanger scEng;
    public SceneChanger scIndo;

    private bool isEng;
    private bool isChanged;

    void Start()
    {
        GameObject language = GameObject.Find("Language Button");
        isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        isChanged = isEng;
    }

    void Update()
    {
        GameObject language = GameObject.Find("Language Button");
        isChanged = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng != isChanged)
        {
            change();
        }
    }

    public void change()
    {
        GameObject language = GameObject.Find("Language Button");
        isEng = language.GetComponent<ManualLanguageController>().getLanguage();
        if (isEng)
        {
            engDropdown.SetActive(true);
            engDropdown.GetComponent<TMP_Dropdown>().value = scIndo.getCurrentIndex();
            scEng.ActionToCall(scIndo.getCurrentIndex());
            indoDropdown.SetActive(false);
        }
        else
        {
            indoDropdown.SetActive(true);
            indoDropdown.GetComponent<TMP_Dropdown>().value = scEng.getCurrentIndex();
            scIndo.ActionToCall(scEng.getCurrentIndex());
            engDropdown.SetActive(false);
        }
        
    }
}
