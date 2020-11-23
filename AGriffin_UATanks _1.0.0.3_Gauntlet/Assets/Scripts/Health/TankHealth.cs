using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    // Variables for health
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    // Variable for score for TakeDamage function
    public Points score;

    // Start called before first frame update
    private void Start()
    {
        // connect shown player health to maxHealth allowed
        currentHealth = maxHealth;
        score = GetComponent<Points>();
    }

    // future reference to reset player health
    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }
    
    // player/ai take damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        // debugging log
        Debug.Log("Current Health " + currentHealth);   

        // if statement for player/ai finding death
        if (currentHealth <= 0)
        {
            // send points to Points.cs 
            score.GetComponent<Points>().AddToScore(score.enemyPoints);

            // IF death, destroy object
            Destroy(gameObject);
        }
    }





}
