using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void Clicked(string t)
    {
        text.text += t;
    }
}
