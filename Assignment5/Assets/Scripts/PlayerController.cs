/*
 * Gerard Lamoureux
 * PlayerController
 * Assignment 5
 * Handles player base and game state
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController thisPlayerController;

    public GameObject gameOverPanel;

    public TextMeshProUGUI text;

    public int health = 300;

    public int damage = 40;

    public bool GameOver = false;

    private void Awake()
    {
        thisPlayerController = this;
    }

    private void Update()
    {
        text.text = "Base Health: " + health;

        if (Input.GetKeyDown(KeyCode.R))
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    private void Die()
    {
        GameOver = true;
        gameOverPanel.SetActive(true);
    }
}
