using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth =100;
    public int currentHealth;
    
    void Start(){
        
        currentHealth = maxHealth;
    }
    

    void Update(){
       
    }

    
    public void TakeDamage(int damage){
        currentHealth -= damage;  
    }

    void OnCollisionEnter(Collision collisionInfo) //Ativa a detecção de colisão;
    {
        
        if(collisionInfo.gameObject.name == "Bullet(Clone)") //Pega o nome do objeto com qual o inimigo irá colidir;
        
        {
          Debug.Log("OH NO!"); // Texto que aparecerá no Console após colisão com o objeto;
          TakeDamage(20); 
          
          if(currentHealth==0) 
          {
              Destroy(gameObject);  
          }
        }
    }
}
