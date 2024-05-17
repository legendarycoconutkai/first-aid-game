using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleActivation : MonoBehaviour
{
    [SerializeField] private Camera cam;
    public GameObject[] objs;
    public MonoBehaviour scriptsToActivate;

    private bool isActive;

    void Start()
    {
        foreach (var obj in objs)
        isActive = obj.activeSelf;
    }

    void Update()
    {
        objectVisibleActivation();
    }

    public void objectVisibleActivation()
    {
        bool shouldActivate = cam.orthographicSize <= 2;

        // If the object's state needs to change, update it
        if (shouldActivate && !isActive)
        {
            foreach (var obj in objs)
            obj.SetActive(true);
            isActive = true;
            scriptsToActivate.enabled = true; 
            Debug.Log("True");
        }
        else if (!shouldActivate && isActive)
        {
            foreach (var obj in objs)
            obj.SetActive(false);
            isActive = false;
            Debug.Log("False");
            scriptsToActivate.enabled = false;
        }
    }
}
