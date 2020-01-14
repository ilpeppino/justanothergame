using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 10f;
    private AudioSource thrustingRocket;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrustingRocket = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back);
        } 
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);

            if (!thrustingRocket.isPlaying)
            {
                PlayThrustAudio();
            }

        }

        else
        {
            StopThrustAudio();
        }
    }

    private void StopThrustAudio()
    {
        thrustingRocket.Stop();
    }

    private void PlayThrustAudio()
    {
        thrustingRocket.Play();
    }
}
