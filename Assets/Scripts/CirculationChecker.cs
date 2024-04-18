using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirculationChecker : MonoBehaviour
{
    public GameObject[] BodyParts;
    public PrimarySurveyController pcs;
    public bool[] bools;
    public bool allTrue;

    void Start()
    {
        bools = new bool[BodyParts.Length];
        for (int i = 0; i < bools.Length; i++)
        {
            bools[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < BodyParts.Length; i++)
        {
            if (BodyParts[i].activeSelf)
            {
                bools[i] = true;
            }
        }

        allTrue = true;

        foreach (bool b in bools)
        {
            if (!b)
            {
                allTrue = false;
                break;
            }
        }

        if (allTrue)
        {
            pcs.booleanController(5);
        }
    }
}
