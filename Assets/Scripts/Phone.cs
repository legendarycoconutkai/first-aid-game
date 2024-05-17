using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;


public class Phone : MonoBehaviour
{
    public TextMeshProUGUI numbers;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearbt;
    public GameObject callbutton;

    public GameObject CallInterface;
    public GameObject CallingInterface;
    public GameObject FailedCallInterface;
    public GameObject panel;

    public void b1()
    {
        numbers.text = numbers.text + "1";
    }
    public void b2()
    {
        numbers.text = numbers.text + "2";
    }
    public void b3()
    {
        numbers.text = numbers.text + "3";
    }
    public void b4()
    {
        numbers.text = numbers.text + "4";
    }
    public void b5()
    {
        numbers.text = numbers.text + "5";
    }
    public void b6()
    {
        numbers.text = numbers.text + "6";
    }
    public void b7()
    {
        numbers.text = numbers.text + "7";
    }
    public void b8()
    {
        numbers.text = numbers.text + "8";
    }
    public void b9()
    {
        numbers.text = numbers.text + "9";
    }
    public void b0()
    {
        numbers.text = numbers.text + "0";
    }

    public void clearEvent()
    {
        numbers.text = null;
    }
    public void callenvent()
    {
        if (numbers.text == "911")
        {
            CallInterface.SetActive(false);
            CallingInterface.SetActive(true);
            panel.SetActive(true);
        }
        else
        {
            CallInterface.SetActive(false);
            FailedCallInterface.SetActive(true);
        }

        clearEvent();
    }
}