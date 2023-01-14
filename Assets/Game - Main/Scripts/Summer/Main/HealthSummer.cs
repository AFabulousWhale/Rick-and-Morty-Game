using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSummer: MonoBehaviour
{
    public RandomSounds _RandomSounds;

    public int maxHealth = 175;
    public int currentHealth;
    public TMPro.TextMeshProUGUI HealthS;

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
            HealthS.text = currentHealth.ToString();
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            HealthS.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthS.text = currentHealth.ToString();

        healthBar.SetHealth(currentHealth);
    }
}
