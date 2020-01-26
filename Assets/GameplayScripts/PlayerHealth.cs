using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image healthDamage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, .1f);
    bool isDead;
    bool damaged;
    
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged)
            healthDamage.color = flashColor;
        else
            healthDamage.color = Color.Lerp(healthDamage.color, Color.clear, flashSpeed * Time.deltaTime);
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if(currentHealth<=0 && !isDead)
        {
            //Death();
            isDead = true;
        }
    }

  /*  void Death()
    {
        isDead = true;
    }*/

}
