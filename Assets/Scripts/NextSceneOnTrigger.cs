using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene().buildIndex <= 1) //Checks to see if its on level 1 or not
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Goes up a level basically
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
