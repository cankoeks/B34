using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B3_BallMover : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpforce = 8f;
    private CharacterController controller;
    private bool isgrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, speed*2);
        } else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, speed);
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, speed);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, speed);
        }

        if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, speed);
        }

        if (isgrounded)
        {
            if(Input.GetKey("space"))
            {
                Debug.Log("Space pressed: Jumped");
                rb.velocity = new Vector3(0, jumpforce, 0);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            rb.useGravity = false;
            isgrounded = true;
        }
        if (collision.gameObject.tag == "deathzone")
        {
            B3_SceneHandler.isGameOver = true;
        }
        if (collision.gameObject.tag == "finish")
        {
            B3_HighscoreHandler.SetHighscore();
            B3_SceneHandler.isGameOver = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            rb.useGravity = true;
            isgrounded = false;
        }
    }
}
