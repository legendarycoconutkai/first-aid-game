using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFrontReinitialised : MonoBehaviour
{
    public MovementCam mc;
    private void OnEnable()
    {
        mc.resetCam();
    }
}
