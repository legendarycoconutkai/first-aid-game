using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenScript : MonoBehaviour
{
    public GameObject fullScreenWarning;

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
