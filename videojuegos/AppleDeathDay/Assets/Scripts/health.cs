using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class health : MonoBehaviour
{
    public int maxHealth = 3; 
    public static int health_;
    public Image[] apples;
    public Sprite fullApple;
    public Sprite bittenApple;
    private GameObject c;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        health_ = maxHealth; 
        gameOverText.gameObject.SetActive(false);
    }

    public void Damage(int damage)
    {
        health_ -= damage;
        if (health_ <= 0)
        {
            gameOverText.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        foreach (Image img in apples)
        {
            img.sprite = bittenApple; 
        }
        for (int i = 0; i < health_; i++) 
        {
            apples[i].sprite = fullApple;
        }
        
    }
    
}
