using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Detects when the ball touches the goal and then the player wins.
/// </summary>
public class Goal : MonoBehaviour
{
    public GameObject winText;
    public GameObject button;
    public AudioSource music;
    public AudioSource cheer;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Teeeeech!");
        if (collision.tag == "Player" && !GameOver.isGameOver)
        {
            winText.SetActive(true);
            button.SetActive(true);
            music.Pause();
            audioSource.Play();
            Debug.Log("Entered goal!");
            GameOver.isGameOver = true;
            cheer.Play();
        }
    }
}
