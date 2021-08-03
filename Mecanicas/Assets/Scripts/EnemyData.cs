using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName ="My Game/Enemy data")]
public class EnemyData : ScriptableObject
{
    
    public float MaxHealth = 10;
    public float speed = 2;
    public float damage = 50;
public TypeEnemy myDropDown = new TypeEnemy();
}
public enum TypeEnemy
     {
         Fire, 
         Grass, 
         Water,
         Rock,
         normal
     };