using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSupport : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    private float verticalInput;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Use fixed update for physics code, because 
    // we need to be careful about how often we call expensive, 
    // hardware intenstive physics stuff
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}