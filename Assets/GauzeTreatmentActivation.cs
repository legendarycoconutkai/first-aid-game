using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GauzeTreatmentActivation : MonoBehaviour
{
    public GameObject[] TreatmentButton;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject treatment in TreatmentButton)
        {
            treatment.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActivateTreatmentButtons();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                ActivateTreatmentButtons();
            }
        }
    }

    private void ActivateTreatmentButtons()
    {
        foreach (GameObject treatment in TreatmentButton)
        {
            treatment.SetActive(true);
        }
    }

    public void DisableTreatmentButton()
    {
        foreach (GameObject treatment in TreatmentButton)
        {
            treatment.SetActive(false);
        }
    }


}
