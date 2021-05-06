using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
  
    public CharacterController controller;
    public float speed = 10f;
   
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        controller.Move(direction * speed * Time.deltaTime);

        if(direction.magnitude >= 0.1)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
