using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoToBeBroughtOver : MonoBehaviour
{
    public GameObject[] injuriesObj;
    public GameObject[] dangerObj;

    public Dictionary<string, bool> injuries;
    public Dictionary<string, bool> dangers;

    private bool isChanged;

    private void Start()
    {
        injuries = new Dictionary<string, bool>
        {
            { "LeftArm", false },
            { "RightArm", true },
            { "LeftLeg", false },
            { "RightLeg", false },
            { "Abdomen", false }
        };

        dangers = new Dictionary<string, bool>
        {
            { "sickle", true },
            { "box", false },
            { "scissors", false }
        };

        isChanged = false;
    }

    public void updateInfo()
    {

        if (injuriesObj[0].GetComponent<Toggle>().isOn)
        {
            injuries["LeftArm"] = true;
            isChanged = true;
        }

        if (injuriesObj[1].GetComponent<Toggle>().isOn)
        {
            injuries["RightArm"] = true;
        }

        if (injuriesObj[2].GetComponent<Toggle>().isOn)
        {
            injuries["LeftLeg"] = true;
            isChanged = true;
        }

        if (injuriesObj[3].GetComponent<Toggle>().isOn)
        {
            injuries["RightLeg"] = true;
            isChanged = true;
        }

        if (injuriesObj[4].GetComponent<Toggle>().isOn)
        {
            injuries["Abdomen"] = true;
            isChanged = true;
        }

        if (dangerObj[0].GetComponent<SpriteRenderer>().enabled)
        {
            dangers["sickle"] = true;
        }

        if (dangerObj[1].GetComponent<SpriteRenderer>().enabled)
        {
            dangers["box"] = true;
        }

        if (dangerObj[2].GetComponent<SpriteRenderer>().enabled)
        {
            dangers["scissors"] = true;
        }

        foreach (var injury in injuries)
        {
            Debug.Log($"{injury.Key}: {injury.Value}");
        }

        foreach (var d in dangers)
        {
            Debug.Log($"{d.Key}: {d.Value}");
        }
    }

    public Dictionary<string, bool> getInjuries()
    {
        return injuries;
    }

    public Dictionary<string, bool> getDangers()
    {
        return dangers;
    }
}
