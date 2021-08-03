using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName ="My Game/Enemy data")]
public class Data : ScriptableObject
{
    
    public float MaxHealth = 10;
    public float damage = 50;
    public TypeEnemy Tipo = new TypeEnemy();
}
public enum TypeEnemy
     {
         Fire, 
         Grass, 
         Water,
         Rock,
         normal,
        lifeItem,
        AmmoFire,
        AmmoWater,
        AmmoGrass,
        AmmoRock,
        AmmoNormal
     };