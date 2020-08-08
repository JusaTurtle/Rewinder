using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offSet;
    [SerializeField] private float smoothTime;
    private Vector2 smoothVelocity;

    private void Update()
    {
        Vector2 pos = Vector2.SmoothDamp(transform.position, target.position, ref smoothVelocity, smoothTime);
        transform.position = (Vector3)pos + offSet;
    }
}
