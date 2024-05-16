using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewritterEffectTutorial : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    public void chgText(string t)
    {
        text.text = "";
        StartCoroutine(Typewriter(t));
    }

    IEnumerator Typewriter(string t)
    {
        foreach (char c in t)
        {
            text.text += c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
