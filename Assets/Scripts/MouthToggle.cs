using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouthToggle : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private GameObject targetObject;

    void Start()
    {
        if (slider != null && targetObject != null)
        {
            // Add listener to the slider to call OnSliderValueChanged when the value changes
            slider.onValueChanged.AddListener(OnSliderValueChanged);

            // Initialize the state based on the slider's starting value
            OnSliderValueChanged(slider.value);
        }
    }

    private void OnSliderValueChanged(float value)
    {
        // Check if the value is close to 1 or 0 and activate/deactivate accordingly
        if (value >= 1f)
        {
            targetObject.SetActive(true);
        }
        else
        {
            targetObject.SetActive(false);
        }
    }
}
