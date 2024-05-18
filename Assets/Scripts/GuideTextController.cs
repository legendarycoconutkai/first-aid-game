using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GuideTextController : MonoBehaviour
{
    public float targetTime;
    private float targetTime1;
    private void OnEnable()
    {
        targetTime1 = targetTime;
    }
    void Update()
    {
        targetTime1 -= Time.deltaTime;

        if (targetTime1 <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
