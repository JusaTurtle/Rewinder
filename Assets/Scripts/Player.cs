using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Rewindable> rewinders;
    [SerializeField] private KeyCode rewindKey;
    public AudioSource rewindSound;

    private void Awake() {
        rewinders = new List<Rewindable>();
        var rewindableObjects = GameObject.FindGameObjectsWithTag("Rewind");

        foreach(var r in rewindableObjects)
        {
            rewinders.Add(r.GetComponent<Rewindable>());
        }
    }

    private void Update() {
        if(Input.GetKeyDown(rewindKey))
        {
            foreach(Rewindable r in rewinders)
            {
                r.Rewind();
            }

            rewindSound.Play();
        }
    }
}