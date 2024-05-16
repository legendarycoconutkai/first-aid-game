using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IsThisObjectInCam : MonoBehaviour
{
    public Transform target;
    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(target.position);
        if (viewPos.x > 0 && viewPos.y>0)
            Debug.Log("target is in the camera view!");
        else
            Debug.Log("target is not in the camera view!");
    }
}
