using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Playermovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 7f;
    RaycastHit hit;
    Rigidbody rb;
    public Transform playerTransform;
   
    void Update()
    {
       
        rb = GetComponent<Rigidbody>();
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        controller.Move(direction * speed * Time.deltaTime);

        if(direction.magnitude >= 0.1)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
       
        
        // 
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            Vector3 playerToMouse = hit.point - transform.position;
            playerToMouse.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            rb.MoveRotation (newRotation);
           
        }
        
    } 
}
