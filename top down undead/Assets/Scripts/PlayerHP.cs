using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public int health = 3;
    public Text healthText;
    public Slider HealthBar;
    public int lives;
    private void Start()
    {
        healthText.text = "HP: " + health;
        HealthBar.maxValue = health;
        HealthBar.value = health;
        lives = PlayerPrefs.GetInt("lives");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            healthText.text = "HP: " + health;
            HealthBar.value = health;
            if (health < 1)
            {
                if (lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("gameover");
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health = health - 1;
            healthText.text = "HP: " + health;
            HealthBar.value = health;
            if (health < 1)
            {
                if (lives > 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("gameover");
                }
            }

        }
    }
}
