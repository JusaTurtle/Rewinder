using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private KeyCode pauseKey;
    [SerializeField] private GameObject pauseScreen;
    private bool isPaused;

    public bool IsPaused { get => isPaused; set => isPaused = value; }

    private void Start() {
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            isPaused = !isPaused;
        }
        pauseScreen.SetActive(isPaused);

        if(isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
