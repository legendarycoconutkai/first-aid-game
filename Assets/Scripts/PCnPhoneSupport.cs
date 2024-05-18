using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCnPhoneSupport : MonoBehaviour
{

    public GameObject AdminMainPanel;
    public GameObject AdminPC;
    public GameObject AdminPhone;

    void Update()
    {
        // Detect mouse click for PC
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(mousePos);
            if (collider != null && collider.gameObject == gameObject)
            {
                OnMouseClick();
            }
        }

        // Detect touch for mobile
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                Collider2D collider = Physics2D.OverlapPoint(touchPos);
                if (collider != null && collider.gameObject == gameObject)
                {
                    OnTouch();
                }
            }
        }
    }

    void OnMouseClick()
    {
        AdminMainPanel.SetActive(false);
        AdminPC.SetActive(true);
        Debug.Log("Box clicked on PC!");
    }

    void OnTouch()
    {
        AdminMainPanel.SetActive(false);
        AdminPhone.SetActive(true);
        Debug.Log("Box touched on mobile!");
    }
}
