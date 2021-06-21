using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Transform Player;
    public NavMeshAgent Agent;
    public LayerMask PlayerLayer;
    public Transform enemyFirePoint;
    int damage = 10;
    bool sla;
    void Start()
    {
        
        currentHealth = maxHealth;
    }
    
     
         
     

    void Update()
    {
        Agent.destination = Player.position;
        
        //if(Agent.destination == Player.position)
        //{

            //Shoot();
       // }
        
    }

    //void Shoot()
   // {
    //   BulletPrefab = hit.transform.gameObject;
     //  if(bulletPrefab == null)
     //  {
       //    bulletPrefab =   Instantiate(Bullet) as GameObject;
      //     bulletPrefab.transform.position = transform.TransformPoint (Vector3.foward * 1.5f);
      //     bulletPrefab.transform.rotation = transform.rotation;
      // }
    //}
    

    void Attack()
    {
        FindObjectOfType<PlayerController>().maxHealth -= damage;

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
