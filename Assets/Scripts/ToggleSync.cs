using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ToggleSync : MonoBehaviour {
    public Toggle adminSettings;
    public Toggle adminDone;

    void Start() {
        adminSettings.isOn = adminDone.isOn;

        adminSettings.onValueChanged.AddListener(OnAdminSettingsToggleValueChanged);
        adminDone.onValueChanged.AddListener(OnAdminDoneToggleValueChanged);
    }

    void OnAdminSettingsToggleValueChanged(bool newValue) {
        adminDone.isOn = newValue;
    }

    void OnAdminDoneToggleValueChanged(bool newValue) {
        adminSettings.isOn = newValue; 
    }
}

