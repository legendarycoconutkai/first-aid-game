using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullscreenScript : MonoBehaviour
{
    public GameObject fullScreenWarning;

    public Button fullscreenButton;

    void Start()
    {
        if (fullscreenButton != null)
        {
            fullscreenButton.onClick.AddListener(EnterFullscreen);
        }
        else
        {
            Debug.LogError("Fullscreen button is not assigned in the inspector.");
        }
    }

    void EnterFullscreen()
    {
        Screen.fullScreen = true;
        Debug.Log("Entering fullscreen mode.");
    }

    // Action to trigger when the player is not in fullscreen mode
    private void TriggerAction()
    {
        fullScreenWarning.SetActive(true);
    }

    void Update()
    {
        // Check if the application is not in fullscreen mode
        if (!Screen.fullScreen)
        {
            TriggerAction();
        }
        else
        {
            fullScreenWarning.SetActive(false);
        }
    }
}
