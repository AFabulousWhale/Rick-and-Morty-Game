using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRick : MonoBehaviour
{
    public ChangingCharacter _ChangingCharacter;
    public RandomSounds _RandomSounds;

    public int maxHealth = 200;
    public int currentHealth;
    public TMPro.TextMeshProUGUI HealthR;

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
            HealthR.text = currentHealth.ToString();
        }
        else if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            HealthR.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthR.text = currentHealth.ToString();

        healthBar.SetHealth(currentHealth);
    }
}
