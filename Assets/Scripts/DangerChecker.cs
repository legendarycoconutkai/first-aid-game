using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerCheckerAndGenerator : MonoBehaviour
{
    public GameObject[] dangersObj;
    public PrimarySurveyController psc;
    public GuideTextLanguageManager gtlm;

    private int d;

    private Dictionary<string, bool> dangers;

    void Start()
    {
        GameObject ir = GameObject.Find("InfoRecorder");
        dangers = ir.GetComponent<InfoToBeBroughtOver>().getDangers();

        int index = 0;
        foreach (var danger in dangers)
        {
            if (index < dangersObj.Length)
            {
                if (danger.Value == true)
                {
                    dangersObj[index].SetActive(true);
                    Debug.Log($"{danger.Key} is true, activating {dangersObj[index].name}");
                }
                else
                {
                    dangersObj[index].SetActive(false);
                    Debug.Log($"{danger.Key} is false, deactivating {dangersObj[index].name}");
                }
            }
            else
            {
                Debug.LogError("Index out of bounds for dangersObj array.");
            }
            index++;
        }
    }

    void Update()
    {
        d = 0;

        foreach (GameObject danger in dangersObj)
        {
            if (danger.activeSelf)
            {
                d++;
            }
        }

        if (d == 0)
        {
            psc.booleanController(0);
            gtlm.booleanController(0);
            this.enabled = false;
        }
    }
}
