using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public GameObject frontScene;
    public GameObject SideScene;
    public GameObject LeftSideScene;
    public GameObject RightSideScene;

    [SerializeField] private TMP_Dropdown dropdown;

    public int currentIndex;

    public void ActionToCall(int index)
    {
        currentIndex = index;
        if (index == 0)
        {
            frontScene.SetActive(true);
            SideScene.SetActive(false);
            LeftSideScene.SetActive(false);
            RightSideScene.SetActive(false);
        }

        else if(index == 1)
        {
            frontScene.SetActive(false);
            SideScene.SetActive(true);
            LeftSideScene.SetActive(true);
            RightSideScene.SetActive(false);
        }

        else if (index == 2)
        {
            frontScene.SetActive(false);
            SideScene.SetActive(true);
            LeftSideScene.SetActive(false);
            RightSideScene.SetActive(true);
        }
    }

    public int getCurrentIndex()
    {
        return currentIndex;
    }
}
