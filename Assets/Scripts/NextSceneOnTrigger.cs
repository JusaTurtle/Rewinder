using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            SceneChanger.NextScene();
        }
    }
}
