using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTextController : MonoBehaviour
{
    float targetTime = 1.0f;
    private void OnEnable()
    {
        targetTime = 1.0f;
    }
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        this.gameObject.SetActive(false);
    }
}
