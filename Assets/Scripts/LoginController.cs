using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoginController : MonoBehaviour
{
    public TMP_InputField nameInputField;
    string playerName;
    public LoadScene loadScene;
    public void confirmButtonClicked()
    {
        playerName = nameInputField.text.Trim();
        

        if (!string.IsNullOrEmpty(playerName)){
            LoadSceneAndKeepValue();
            Debug.Log("Player name entered: " + playerName);
            loadScene.checkIfError(2,1);
        }
        else
        {
            Debug.Log("Please enter your name!");
        }
    }
    
    public void LoadSceneAndKeepValue()
    {
        StaticData.valueToKeep = playerName;
    }

}
