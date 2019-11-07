using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the ball touches the goal and then the player wins.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Teeeeech!");
        if (collision.tag == "Player")
        {
            winText.SetActive(true);
            audioSource.Play();
            Debug.Log("Entered goal!");
        }
    }
}
