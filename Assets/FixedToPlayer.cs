using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedToPlayer : MonoBehaviour
{
    Transform player;

    public float offsetX;
    public float offsetY;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, player.position.y + offsetY, transform.position.z);
    }
}
