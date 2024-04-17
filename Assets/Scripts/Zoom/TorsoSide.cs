using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TorsoSide : MonoBehaviour
{
    public GameObject sideCam;
    public GameObject TorsoCam;
    public GameObject SideTrigger;
    //public GameObject closeButton;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        SideTrigger.GetComponent<Button>().onClick.AddListener(()=>sideZoom());
        //closeButton.GetComponent<Button>().onClick.AddListener(() => closeSideZoom());
    }

    public void sideZoom()
    {
        sideCam.SetActive(true);
        TorsoCam.SetActive(false);
    }

    public void closeSideZoom()
    {
        sideCam.SetActive(false);
        TorsoCam.SetActive(true);
    }
}
