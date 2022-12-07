using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1HealthSystem : MonoBehaviour
{
    public int maxhealth = 100;
    public int currentHealth;
    public Animator anim;  // Needs animator for death/ gameover animation before it can be called 
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxhealth;
    }
    void takeDamage(int amount)  // needs to be in the called by the collider healthcomponent.takeDamage();
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Debug.Log("Death");
            // Game Over/ Death Animation 
           // anim.SetBool("Is Dead", true);
        }
    }

}
