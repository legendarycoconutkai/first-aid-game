using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public InfoToBeBroughtOver info;

    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

    public void checkIfError(int errorSceneID, int SceneID)
    {
        if (info.getIsChanged())
        {
            SceneManager.LoadScene(errorSceneID);
        }
        else
        {
            SceneManager.LoadScene(SceneID);
        }
    }
}
