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
        {
            
        }
    }

    
    public void TakeDamage(int damage){
        currentHealth -= damage;  
        Healthbar.SetHealth(currentHealth);
    }

    void OnCollisionEnter(Collision collisionInfo) //Ativa a detecção de colisão;
    {
        
        if(collisionInfo.gameObject.name == "Enemy") //Pega o nome do objeto com qual o player irá colidir;
        
        {
          Debug.Log("OH NO!"); // Texto que aparecerá no Console após colisão com o objeto;
          TakeDamage(20); 
          
          if(currentHealth<=0) 
          {
              Debug.Log("you died :(");  
          }

        }

        
    }

}