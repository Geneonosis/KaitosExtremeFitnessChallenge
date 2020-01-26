using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossClick : MonoBehaviour
{
    public EnemyHealth eh;
    public Button boss;
    //public PlayerHealth ph;
    public int currentHealth;
    bool isDead;
    bool damaged;
    public Image healthDamage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, .1f);
    public int startingHealth = 100;

    void Awake()
    {
        currentHealth = startingHealth;
    }
    void Update()
    {
        if (damaged)
            healthDamage.color = flashColor;
       
        damaged = false;
    }

    void OnMouseOver()
    {
        if (boss){
            // Whatever you want it to do.
            TakeDamage(50);
        }
        print(eh.currentHealth);
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            isDead = true;
            DestroyObject(eh);
        }
    }

}
