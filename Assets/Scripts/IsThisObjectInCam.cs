using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IsThisObjectInCam : MonoBehaviour
{
    public Transform [] targets;
    public Dictionary<Transform, bool> targetState;

    [SerializeField]
    private Camera cam;

    void OnEnable()
    {
        cam = GetComponent<Camera>();
        
    }

    private void Start()
    {
        targetState = new Dictionary<Transform, bool>();

        foreach (Transform target in targets)
        {
            targetState[target] = false;
        }
    }
    void Update()
    {
        foreach (Transform target in targets)
        {
            CheckObjectInView(target);
        }

        bool allInView = true;
        foreach (Transform target in targets)
        {
            if (!targetState[target])
            {
                allInView = false;
                break;
            }
        }

        if (allInView)
        {
            Debug.Log("All targets is viewed");
        }
    }

    public void CheckObjectInView(Transform target)
    {
        Vector3 viewPos = cam.WorldToViewportPoint(target.position);
        bool isInView = viewPos.x > 0 && viewPos.x < 1 && viewPos.y > 0 && viewPos.y < 1;
        if (isInView && !targetState[target]) {
            targetState[target] = true;
            Debug.Log("Target is Viewed");
        }
    }
}
