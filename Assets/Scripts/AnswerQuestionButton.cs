using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerQuestionButton : MonoBehaviour
{
    public TextMeshProUGUI t;
    public TypewriterEffectPhone tep;
    public void clicked()
    {
        if (t.IsActive())
        {
            tep.showTextSub(t.text);
        }

    }
}
