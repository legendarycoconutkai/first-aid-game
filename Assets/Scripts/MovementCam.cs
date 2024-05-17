using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementCam : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize;

    [SerializeField]
    private SpriteRenderer bgRenderer;

    [SerializeField]
    private Toggle toggle;

    private float bgMinX, bgMaxX, bgMinY, bgMaxY;

    private Vector3 dragOrigin;

    private Vector3 oriPos;

    private void Awake()
    {
        bgMinX = bgRenderer.transform.position.x - bgRenderer.bounds.size.x / 2f;
        bgMaxX = bgRenderer.transform.position.x + bgRenderer.bounds.size.x / 2f;

        bgMinY = bgRenderer.transform.position.y - bgRenderer.bounds.size.y / 2f;
        bgMaxY = bgRenderer.transform.position.y + bgRenderer.bounds.size.y / 2f;

        oriPos = ClampCamera(cam.transform.position);
    }

    private void Update()
    {
        PanCamera();
    }

    private void PanCamera()
    {
        //save position of mouse in world space when drag starts
        if (Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

            cam.transform.position = ClampCamera(cam.transform.position + difference); 
        }
    }
    public void ZoomIn()
    {
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }

    public void ZoomOut()
    {
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = bgMinX + camWidth;
        float maxX = bgMaxX - camWidth;
        float minY = bgMinY + camHeight;
        float maxY = bgMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3 (newX, newY, targetPosition.z);
    }

    public void resetCam()
    {

        cam.orthographicSize = Mathf.Clamp(5, minCamSize, maxCamSize);
        cam.transform.position = oriPos;
        toggle.onValueChanged.Invoke(false);
        toggle.isOn = false;
    }
}


