using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibilityWithButton : MonoBehaviour {
    public GameObject targetObject; // The object to toggle
    private Renderer objectRenderer;

    void Start() {
        if (targetObject != null) {
            objectRenderer = targetObject.GetComponent<Renderer>();

            if (objectRenderer == null) {
                Debug.LogError("No Renderer found on the target object!");
            }
        } else {
            Debug.LogError("No target object assigned!");
        }
    }

    public void ToggleVisibility() {
        if (objectRenderer != null) {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
