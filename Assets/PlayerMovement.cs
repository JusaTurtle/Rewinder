using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; //Movement Speed
    public float jVelocity; //Jump Height

    Rigidbody2D rb;
    BoxCollider2D bc;
    [SerializeField] private LayerMask glm; //Ground Layermask
    public AudioSource jumpSound; //Jumping Sound Effect

    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, .1f, glm); //Generate a raycast under player that only detects glm
        return hit.collider != null; //If the ray hits something, it returns as true
                                     //If it doesn't hit something, it returns as false
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Gives script access to rigidbody
        bc = GetComponent<BoxCollider2D>(); //Gives script access to collider
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //Controls for horizontal movement

        rb.velocity = new Vector2(x, rb.velocity.y); //Horizontal Movement Function

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && isGrounded()) //If jump key is pressed and isgrounded, the player will jump
        {
            rb.velocity = new Vector2(rb.velocity.x, jVelocity); //Jumping function
            jumpSound.Play(); //Plays the sound (Obviously)
        }
    }
}

