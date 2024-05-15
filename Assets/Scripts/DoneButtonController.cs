using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoneButtonController : MonoBehaviour
{
    public float targetTime;
    public GameObject doneButton;
    public GameObject cdButton;
    public TextMeshProUGUI cdButtonText;
    private float elapsedTime = 0f;

    private void OnEnable()
    {
        targetTime = GenerateNormalValue(180f, 300f);
        cdButton.SetActive(true);
        cdButtonText.text = targetTime.ToString("F0") + "s";
    }
    void Update()
    {
        targetTime -= Time.deltaTime;
        elapsedTime += Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        if (elapsedTime >= 1.0f)
        {
            elapsedTime = 0f;
            cdButtonText.text = targetTime.ToString("F0") + "s";
        }
    }

    void timerEnded()
    {
        cdButton.SetActive(false);
        doneButton.SetActive(true);
    }

    float GenerateNormalValue(float min, float max)
    {
        float mean = (min + max) / 2f;
        float sigma = (max - mean) / 3f;

        float value;
        do
        {
            value = GenerateGaussian(mean, sigma);
        } while (value < min || value > max);

        return value;
    }

    float GenerateGaussian(float mean, float sigma)
    {
        System.Random rand = new System.Random();
        // Using Box-Muller transform to generate a standard normal distribution (mean=0, stdDev=1)
        float u1 = 1.0f - (float)rand.NextDouble(); // uniform(0,1] random doubles
        float u2 = 1.0f - (float)rand.NextDouble();
        float randStdNormal = Mathf.Sqrt(-2.0f * Mathf.Log(u1)) * Mathf.Sin(2.0f * Mathf.PI * u2);
        // Scale and shift to get the desired normal distribution
        float randNormal = mean + sigma * randStdNormal;
        return randNormal;
    }
}
