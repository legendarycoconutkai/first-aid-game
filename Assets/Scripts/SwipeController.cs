using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    public GameObject Inventory;
    void Update()
    {
        SwipeForTouch();
        SwipeForMouse();
    }
    public void SwipeForTouch()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
                //Debug.Log("First Press Position: " + firstPressPos);
            }
            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                if (currentSwipe.y > 0.3 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    if (firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210)
                    {
                        OpenInventory();
                    }
                    else
                    {
                        //Debug.Log("Not in area");
                    }
                }
                //swipe down
                if (currentSwipe.y < -0.3 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    if (firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210)
                    {
                        CloseInventory();
                    }
                    else
                    {
                        //Debug.Log("Not in area");
                    }
                }
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    //Debug.Log("left swipe");
                }
                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    //Debug.Log("right swipe");
                }
            }
        }
    }

    public void SwipeForMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log("First Press Position: " + firstPressPos);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0.3 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                if (firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210)
                {
                    OpenInventory();
                }
                else
                {
                    //Debug.Log("Not in area");
                }
            }
            //swipe down
            if (currentSwipe.y < -0.3 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                if (firstPressPos.x > 420 && firstPressPos.x < 1490 && firstPressPos.y > 0 && firstPressPos.y < 210)
                {
                    CloseInventory();
                }
                else
                {
                    //Debug.Log("Not in area");
                }
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                //Debug.Log("left swipe");
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                //Debug.Log("right swipe");
            }
        }
    }

    private void OpenInventory()
    {
        Inventory.SetActive(true);
    }

    private void CloseInventory()
    {
        Inventory.SetActive(false);
    }
}
