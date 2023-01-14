using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthJerry: MonoBehaviour
{
    public RandomSounds _RandomSounds;

    public int maxHealth = 175;
    public int currentHealth;
    public TMPro.TextMeshProUGUI HealthJ;

    public HealthBar healthBar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 0)
        {
            currentHealth = 0;
            HealthJ.text = currentHealth.ToString();
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            HealthJ.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthJ.text = currentHealth.ToString();

        healthBar.SetHealth(currentHealth);
    }
}
