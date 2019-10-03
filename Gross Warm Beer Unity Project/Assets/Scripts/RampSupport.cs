using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampSupport : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        // transform.Translate(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("UPDATE METHOD");
        // If the player presses the right arrow the square will move
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -moveSpeed, 0);
        }
    }
}
