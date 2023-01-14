using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMorty : MonoBehaviour
{
    public ChangingCharacter _ChangingCharacter;
    public RandomSounds _RandomSounds;

    public int maxHealth = 150;
    public int currentHealth;
    public TMPro.TextMeshProUGUI HealthM;

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
            HealthM.text = currentHealth.ToString();
        }
        else if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
            HealthM.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthM.text = currentHealth.ToString();

        healthBar.SetHealth(currentHealth);
    }
}
