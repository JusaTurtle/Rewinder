using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public static void NextScene()
    {
        int next = (SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(next % SceneManager.sceneCount);
        Debug.Log(next % SceneManager.sceneCount);
    }

    public static void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void Exit()
    {
        Application.Quit();
    }
}
