using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private PauseScreen pauseScreen;

    public void Restart()
    {
        SceneChanger.Reload();
    }

    public void Menu()
    {
        SceneChanger.LoadScene("Menu");
    }

    public void Resume()
    {
        pauseScreen.IsPaused = false;
    }
}
