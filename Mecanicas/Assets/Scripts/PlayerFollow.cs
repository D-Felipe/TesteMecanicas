using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    

   public Transform playerTransform; //Variável usada para controlar a posição da câmera;

   Vector3 cameraOffset;    // Variável ligada à câmera principal;

   [Range(0.01f, 1.0f)] //Isso aqui cria um slider para mexer no SmoothFactor;

   [SerializeField] float smoothFactor = 0.5f; //Minha variável favorita. Ela é usada pra criar um efeito suave da câmera enquanto o player se move;

    
    void Start()
    {
        cameraOffset = transform.position - playerTransform.position; //Isso aqui vai estavelecer a posição da câmera ao iniciar o game;
    }

 
    void LateUpdate()
    {
        Vector3 newPos = playerTransform.position + cameraOffset; //Já essa belezinha aqui, manterá a câmera seguindo o player;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor); //Sabe o efeito? Então, isso aqui cria ele nos eixos;
    }
}
