using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBarScript Healthbar;
    public int maxHealth =100;
    public int currentHealth;
    void Start(){
        currentHealth = maxHealth;
        Healthbar.SetMaxHealth(maxHealth);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage){
        currentHealth -= damage;  
        Healthbar.SetHealth(currentHealth);
    }

}
