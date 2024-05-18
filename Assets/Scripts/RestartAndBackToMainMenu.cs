using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAndBackToMainMenu : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(1);
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
