using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControllerDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePos);

            if (collider != null && collider.gameObject == gameObject)
            {
                isDragging = true;
                offset = transform.position - mousePos;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            mousePos.z = 0; // Ensure the IK controller stays in the 2D plane
            transform.position = mousePos;
        }
    }
}

