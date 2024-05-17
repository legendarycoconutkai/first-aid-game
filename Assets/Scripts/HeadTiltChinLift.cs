using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class HeadTiltChinLift : MonoBehaviour
{
    public GameObject Head;
    public GameObject eyeClose;
    public GameObject HeadSprite;
    public GameObject OpenMouth1;
    public GameObject OpenMouth2;

    private bool isHeadTilted = false;

    public void headTilted()
    {
        Head.GetComponent<SpriteRenderer>().enabled = false;
        Head.GetComponent<SpriteSkin>().enabled = false;
        eyeClose.SetActive(false);
        HeadSprite.SetActive(true);
        isHeadTilted = true;
    }

    public void headNotTilted()
    {
        Head.GetComponent<SpriteRenderer>().enabled = true;
        Head.GetComponent<SpriteSkin>().enabled = true;
        eyeClose.SetActive(true);
        HeadSprite.SetActive(false);
        isHeadTilted = false;
    }

    public void chinLifted()
    {
        if (isHeadTilted)
        {
            OpenMouth2.SetActive(true);
        }
        else
        {
            OpenMouth1.SetActive(true);
        }
    }
    
    public void chinNotLifted()
    {
        OpenMouth2.SetActive(false);
        OpenMouth1.SetActive(false);
    }
}
