using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypewritterEffectTutorial : MonoBehaviour
{
    public TextMeshProUGUI displayText; // The UI Text component to display the text
    public Button nextButton; // The button to trigger the next part
    public Button skipButton; // The button to skip the typewriter effect
    public GameObject button;
    public GameObject skipButtonObj;
    public GameObject panel;

    public string[] textParts;
    private int currentPartIndex;
    private Coroutine typingCoroutine;

    void Start()
    {
        nextButton.onClick.AddListener(OnNextButtonClicked);
        skipButton.onClick.AddListener(OnSkipButtonClicked);
    }

    // Call this method with the initial string
    public void DisplayText(string fullText)
    {
        panel.SetActive(true);
        skipButtonObj.SetActive(true);
        textParts = SplitTextIntoParts(fullText, 81);
        foreach (string number in textParts)
        {
            Debug.Log(number);
        }
        currentPartIndex = 0;
        if (textParts.Length > 0)
        {
            typingCoroutine = StartCoroutine(Typewriter(textParts[currentPartIndex]));
        }
    }

    // Split the text into parts of specified length
    private string[] SplitTextIntoParts(string text, int partLength)
    {
        List<string> partsList = new List<string>();
        int currentIndex = 0;
        while (currentIndex < text.Length)
        {
            int y = Math.Min(partLength, text.Length - currentIndex);
            string t = text.Substring(currentIndex, y);
            while (t.Length > 0 && t[t.Length - 1] != '.' && y != text.Length - currentIndex)
            {
               y--;
                t = text.Substring(currentIndex, y);
            }
            currentIndex += y;
            partsList.Add(t);
        }
        return partsList.ToArray();
    }

    // Coroutine to handle the typewriter effect
    private IEnumerator Typewriter(string text)
    {
        displayText.text = "";
        foreach (char c in text)
        {
            displayText.text += c;
            yield return new WaitForSeconds(0.05f); // Adjust the delay as needed
        }
        button.SetActive(true); // Enable the button after finishing
    }

    // Button click handler for Next button
    private void OnNextButtonClicked()
    {
        button.SetActive(false); // Disable the button to prevent multiple clicks
        currentPartIndex++;
        if (currentPartIndex < textParts.Length)
        {
            typingCoroutine = StartCoroutine(Typewriter(textParts[currentPartIndex]));
        }
        else
        {
            panel.SetActive(false); // Hide the panel when all parts are displayed
        }
        skipButtonObj.SetActive(true); // Show the Skip button after clicking Next
    }

    // Button click handler for Skip button
    private void OnSkipButtonClicked()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        displayText.text = textParts[currentPartIndex]; // Immediately display the full text
        button.SetActive(true); // Enable the Next button after skipping
        skipButtonObj.SetActive(false); // Hide the Skip button after skipping
    }
}
