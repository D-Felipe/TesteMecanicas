using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   


public class EnemyScript : MonoBehaviour
{
    public EnemyData data;
    [SerializeField] float currentHealth;
    public Transform Player;
    public NavMeshAgent Agent;
    public LayerMask PlayerLayer;
    public Transform enemyFirePoint;
    void Start()
    {
        currentHealth = data.MaxHealth;
    }

    void Update()
    {
        Agent.destination = Player.position;//mexer nisto depois pois ele é o causador dos encoxamentos do enemy no player
    }
}
