using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSupport : MonoBehaviour
{
    public float moveSpeed = 1f;
    public string inputAxis;

    private float verticalInput;
    private Rigidbody2D rigidbody;
    private AudioSource audioSource;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
        if (verticalInput != 0)
        {
            audioSource.Play();
        }
    }

    // Use fixed update for physics code, because 
    // we need to be careful about how often we call expensive, 
    // hardware intenstive physics stuff
    private void FixedUpdate()
    {
        if (!GameOver.isGameOver)
        {
            rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
        }
    }
}