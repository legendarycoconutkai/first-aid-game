using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class SwipeCharacterController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject armCamera;
    public GameObject legCamera;
    public GameObject headCamera;
    public GameObject torsoCamera;
    public GameObject Head;
    public GameObject Arm;
    public GameObject Leg;
    public GameObject Torso;
    private static Boolean closeSwitch;

    // Start is called before the first frame update
    void Start()
    {
        headCamera.SetActive(false);
        legCamera.SetActive(false);
        armCamera.SetActive(false);
        closeSwitch = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        Head.GetComponent<Button>().onClick.AddListener(() => ZoomHead());
        Arm.GetComponent<Button>().onClick.AddListener(() => ZoomArm());
        Leg.GetComponent<Button>().onClick.AddListener(() => ZoomLeg());
        Torso.GetComponent<Button>().onClick.AddListener(() => ZoomTorso());

    }

    private void ZoomHead()
    {    
        DisableAllCameras();
        headCamera.SetActive(true);
    }

    private void ZoomArm()
    {
        DisableAllCameras();
        armCamera.SetActive(true);
    }

    private void ZoomLeg()
    {
        DisableAllCameras();
        legCamera.SetActive(true);
    }

    private void ZoomTorso()
    {
        DisableAllCameras();
        torsoCamera.SetActive(true);
    }



    private void DisableAllCameras()
    {
        mainCamera.SetActive(false);
        headCamera.SetActive(false);
        legCamera.SetActive(false);
        armCamera.SetActive(false);
        torsoCamera.SetActive(false);
    }

}
