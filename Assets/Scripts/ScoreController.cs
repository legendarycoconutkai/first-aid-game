using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreController : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public float timeBetweenReductions = 0.5f; //change this to vary the speed of the score reduction

    private int startValue = 9999;
    private int currentValue;
    private float nextReductionTime = 0.0f;

    private void Start()
    {
        currentValue = startValue;
        scoreText.text = currentValue.ToString();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad > nextReductionTime)
        {
            currentValue--;
            nextReductionTime = Time.timeSinceLevelLoad + timeBetweenReductions;
            scoreText.text = currentValue.ToString();
        }
    }

    public void changeSpeed(float rate)
    {
        nextReductionTime = rate;

        if (rate < 0.5f)
        {
            scoreText.color = Color.black;
        }
        else if (rate == 0.5f)
        {
             scoreText.color = Color.white;
        }
        else
        {
            scoreText.color = Color.green;
        }
    }
}
