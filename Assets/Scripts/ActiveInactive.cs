using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveInactive : MonoBehaviour
{
    public void ToggleActive(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
