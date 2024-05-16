using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObject;

    private bool isObjectActive;

 
    public void ToggleTargetObject()
    {
        if (targetObject != null)
        {
            isObjectActive = !isObjectActive;
            targetObject.SetActive(isObjectActive);
        }
    }
}
