using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypewritterEffectTutorial : MonoBehaviour
{
    public TextMeshProUGUI displayText; // The UI Text component to display the text
    public Button nextButton; // The button to trigger the next part

    private string[] textParts;
    private int currentPartIndex;

    void Start()
    {
        nextButton.onClick.AddListener(OnNextButtonClicked);
    }

    // Call this method with the initial string
    public void DisplayText(string fullText)
    {
        textParts = SplitTextIntoParts(fullText, 64);
        currentPartIndex = 0;
        if (textParts.Length > 0)
        {
            StartCoroutine(Typewriter(textParts[currentPartIndex]));
        }
    }

    // Split the text into parts of specified length
    private string[] SplitTextIntoParts(string text, int partLength)
    {
        int numParts = Mathf.CeilToInt((float)text.Length / partLength);
        string[] parts = new string[numParts];
        for (int i = 0; i < numParts; i++)
        {
            int startIdx = i * partLength;
            parts[i] = text.Substring(startIdx, Mathf.Min(partLength, text.Length - startIdx));
        }
        return parts;
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
        nextButton.interactable = true; // Enable the button after finishing
    }

    // Button click handler
    private void OnNextButtonClicked()
    {
        nextButton.interactable = false; // Disable the button to prevent multiple clicks
        currentPartIndex++;
        if (currentPartIndex < textParts.Length)
        {
            StartCoroutine(Typewriter(textParts[currentPartIndex]));
        }
    }
}
