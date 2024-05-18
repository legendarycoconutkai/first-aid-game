using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject t;
    void OnEnable()
    {
        t.SetActive(true);
    }
}
