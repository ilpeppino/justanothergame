using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // Cached references
    private Rigidbody rb;
    private AudioSource aud_Thrust;

    [SerializeField] [Range(0f, 1000f)] private float _thrustSpeed = 100f;
    [SerializeField] [Range(0f, 1000f)] private float _thrustRotation = 100f;


    // Properties
    private float speed = 10f;

    void Awake()
    {
        Debug.Log("Awake");
        rb = GetComponent<Rigidbody>();
        aud_Thrust = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Thrust();
        Rotate();
    }

    // Checks and apply rocket rotation
    public void Rotate()
    {
        // Physics not applied when rotating
        rb.freezeRotation = true;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * _thrustRotation * Time.deltaTime);
            Debug.Log("Pressed right");
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * _thrustRotation * Time.deltaTime);
            Debug.Log("Pressed left");
        }

        rb.freezeRotation = false;
    }
    // Checks and apply thrust force to the rocket
    public void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * _thrustSpeed * Time.deltaTime);
            Debug.Log("Pressed space");

            if (!aud_Thrust.isPlaying) { aud_Thrust.Play(); }
        }

        else { aud_Thrust.Stop(); }
        
        
    }

}


