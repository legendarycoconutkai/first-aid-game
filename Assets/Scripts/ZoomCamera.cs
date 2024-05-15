using System.Collections;
using UnityEngine;

public class BodyPartZoom : MonoBehaviour
{
    public Camera mainCamera;
    public float zoomSize = 2f; // The size of the camera when zoomed in
    public float zoomSpeed = 2f; // Speed of the zoom transition
    private Vector3 originalPosition;
    private float originalSize;
    private bool isZooming = false;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
        originalPosition = mainCamera.transform.position;
        originalSize = mainCamera.orthographicSize;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePos);

            if (collider != null)
            {
                StartCoroutine(ZoomIn(collider.transform.position));
            }
        }

        if (Input.GetMouseButtonDown(1)) // Right click to zoom out
        {
            StartCoroutine(ZoomOut());
        }
    }

    IEnumerator ZoomIn(Vector3 targetPosition)
    {
        isZooming = true;
        float elapsedTime = 0f;
        Vector3 startPosition = mainCamera.transform.position;
        float startSize = mainCamera.orthographicSize;

        while (elapsedTime < 1f)
        {
            mainCamera.transform.position = Vector3.Lerp(startPosition, new Vector3(targetPosition.x, targetPosition.y, startPosition.z), elapsedTime * zoomSpeed);
            mainCamera.orthographicSize = Mathf.Lerp(startSize, zoomSize, elapsedTime * zoomSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.transform.position = new Vector3(targetPosition.x, targetPosition.y, startPosition.z);
        mainCamera.orthographicSize = zoomSize;
        isZooming = false;
    }

    IEnumerator ZoomOut()
    {
        isZooming = true;
        float elapsedTime = 0f;
        Vector3 startPosition = mainCamera.transform.position;
        float startSize = mainCamera.orthographicSize;

        while (elapsedTime < 1f)
        {
            mainCamera.transform.position = Vector3.Lerp(startPosition, originalPosition, elapsedTime * zoomSpeed);
            mainCamera.orthographicSize = Mathf.Lerp(startSize, originalSize, elapsedTime * zoomSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.transform.position = originalPosition;
        mainCamera.orthographicSize = originalSize;
        isZooming = false;
    }
}
