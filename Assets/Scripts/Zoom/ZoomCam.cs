using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZoomHead : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainCamera;
    public GameObject closeButton;
    public GameObject zoomCam;

    // Update is called once per frame
    void Update()
    {
        closeButton.GetComponent<Button>().onClick.AddListener(() =>closeZoom());
    }

    public void closeZoom()
    {
        mainCamera.SetActive(true);
        zoomCam.SetActive(false);
    }
}
