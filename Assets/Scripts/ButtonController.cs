using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject button;
    public TextMeshProUGUI tmp;

    void Start()
    {
        button.GetComponent<Button>().onClick.AddListener(() => { ButtonClicked(); });
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(object3.transform.position, object2.transform.position);
        tmp.text = "Distance: " + distance.ToString("F2");
        if (distance < 1.8)
        {
            object1.SetActive(true);
        }
        else
        {
            object1.SetActive(false);
        }
    }
    void ButtonClicked()
    {
        Debug.Log("Button clicked");
    }
}
