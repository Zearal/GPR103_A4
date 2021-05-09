using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public SpriteRenderer shipColourRenderer;
    public List<Sprite> colourOptions = new List<Sprite>();
    public static int currentOption = 0;
    public int colourOption = 0;

    public GameObject playerShip;
    public HealthBar healthBar;

    public int maxHealth = 20;
    public int currentHealth;

    private void Start()
    {
        shipColourRenderer.sprite = colourOptions[currentOption];
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GreenLaser")
        {
            currentHealth--;

            healthBar.SetHealth(currentHealth);
            if (currentHealth <= 0)
            {
                GameManager.instance.GameOver();
                
                AudioManager.instance.StopAllAudio();

                Destroy(gameObject);
            }
        }
    }
}
