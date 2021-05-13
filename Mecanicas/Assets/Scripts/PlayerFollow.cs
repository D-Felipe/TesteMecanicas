using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    

   public Transform playerTransform; //Vari�vel usada para controlar a posi��o da c�mera;

   Vector3 cameraOffset;    // Vari�vel ligada � c�mera principal;

   [Range(0.01f, 1.0f)] //Isso aqui cria um slider para mexer no SmoothFactor;

   [SerializeField] float smoothFactor = 0.5f; //Minha vari�vel favorita. Ela � usada pra criar um efeito suave da c�mera enquanto o player se move;

    
    void Start()
    {
        cameraOffset = transform.position - playerTransform.position; //Isso aqui vai estavelecer a posi��o da c�mera ao iniciar o game;
    }

 
    void LateUpdate()
    {
        Vector3 newPos = playerTransform.position + cameraOffset; //J� essa belezinha aqui, manter� a c�mera seguindo o player;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor); //Sabe o efeito? Ent�o, isso aqui cria ele nos eixos;
    }
}
