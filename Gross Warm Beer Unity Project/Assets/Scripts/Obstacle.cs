﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject button;
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
            gameOverText.SetActive(true);
            button.SetActive(true);
            audioSource.Play();
            Debug.Log("Touched obstacle >:(");
            GameOver.isGameOver = true;
        }
    }
}
