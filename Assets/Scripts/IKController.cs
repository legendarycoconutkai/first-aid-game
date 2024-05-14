using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKController : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Vector3 originalPosition;

    public float moveAreaWidth = 4f; // Define the width of the movable area
    public float moveAreaHeight = 3f; // Define the height of the movable area

    void Start()
    {
        // Store the original position
        originalPosition = transform.position;
    }

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

            // Snap back to original position if moved outside the movable area
            if (!IsWithinMoveArea(transform.position))
            {
                transform.position = originalPosition;
            }
        }

        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            mousePos.z = 0; // Ensure the IK controller stays in the 2D plane
            transform.position = mousePos;
        }
    }

    // Check if a position is within the movable area
    bool IsWithinMoveArea(Vector3 position)
    {
        float minX = originalPosition.x - moveAreaWidth / 2f;
        float maxX = originalPosition.x;
        float minY = originalPosition.y - moveAreaHeight / 2f;
        float maxY = originalPosition.y + moveAreaHeight / 2f;

        return position.x >= minX && position.x <= maxX && position.y >= minY && position.y <= maxY;
    }
}


