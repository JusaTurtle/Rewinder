using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewindBar : MonoBehaviour
{
    private Rewinder rewind;
    private Image rewindBar;

    private void Awake() {
        rewindBar = GetComponent<Image>();
        rewind = transform.root.GetComponent<Rewinder>();
    }

    private void Start() {
        rewindBar.enabled = false;
    }

    private void Update()
    {
        if(rewind.IsRewindng)
        {
            rewindBar.enabled = true;
            rewindBar.fillAmount = rewind.GetFillPercent();
        }
        else
        {
            rewindBar.enabled = false;
        }
    }
}
