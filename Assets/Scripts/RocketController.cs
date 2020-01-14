using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // Cached references
    private Rigidbody rb;
    private AudioSource aud_Thrust;

    // Properties
    private float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        aud_Thrust = GetComponent<AudioSource>();
    }
    void Update()
    {
        Rotate();
        Thrust();
    }

    // Checks and apply rocket rotation
    private void Rotate()
    {

        rb.freezeRotation = true;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward);
        }

        rb.freezeRotation = false;
    }
    // Checks and apply thrust force to the rocket
    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);

            if (!aud_Thrust.isPlaying)
            {
                aud_Thrust.Play();
            }

        }

        else
        {
            aud_Thrust.Stop();
        }
    }

}


