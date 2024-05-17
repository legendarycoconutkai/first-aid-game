using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    public BoxCollider2D firstBoxCollider;
    public BoxCollider2D secondBoxCollider;

    public HeadTiltChinLift htcl;

    private enum BoxState { None, First, Second }
    private BoxState initialBoxState = BoxState.None;

    void Update()
    {
        // For mouse inputs
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (firstBoxCollider.OverlapPoint(mousePos))
            {
                initialBoxState = BoxState.First;
            }
            else if (secondBoxCollider.OverlapPoint(mousePos))
            {
                initialBoxState = BoxState.Second;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (initialBoxState == BoxState.First && secondBoxCollider.OverlapPoint(mousePos))
            {
                //Debug.Log("Mouse down in first box and up in second box");
                htcl.headTilted();
            }
            else if (initialBoxState == BoxState.Second && firstBoxCollider.OverlapPoint(mousePos))
            {
                //Debug.Log("Mouse down in first box and up in second box");
                htcl.headNotTilted();
            }
            initialBoxState = BoxState.None;
        }

        // For touch inputs
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                if (firstBoxCollider.OverlapPoint(touchPos))
                {
                    initialBoxState = BoxState.First;
                }
                else if (secondBoxCollider.OverlapPoint(touchPos))
                {
                    initialBoxState = BoxState.Second;
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                if (initialBoxState == BoxState.First && secondBoxCollider.OverlapPoint(touchPos))
                {
                    //Debug.Log("Mouse down in first box and up in second box");
                    htcl.headTilted();
                }
                else if (initialBoxState == BoxState.Second && firstBoxCollider.OverlapPoint(touchPos))
                {
                    //Debug.Log("Mouse down in first box and up in second box");
                    htcl.headNotTilted();
                }
                initialBoxState = BoxState.None;
            }
        }
    }
}
