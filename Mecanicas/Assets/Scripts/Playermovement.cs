using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Playermovement : MonoBehaviour
{
    
    [SerializeField]CharacterController controller; // Essa linha aplica o controle do player;

    [SerializeField] float speed = 7f;  // Isso � a velocidade dele;

    RaycastHit hit;  // A vari�vel necess�ria para o player olhar para onde o mouse for;

    Rigidbody rb;   // Uma vari�vel para criar o Rigidbody;
   
    void Update()
    {
       
        rb = GetComponent<Rigidbody>(); //Instanciamento do Rigidbody;

        float horizontal = Input.GetAxisRaw("Horizontal"); // Controle da Linha X (A,D);

        float vertical = Input.GetAxisRaw("Vertical");     // Controle da Linha Y (W,S);

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; // Permite se mover para horizontal, vertical e trava o Eixo Z;

        controller.Move(direction * speed * Time.deltaTime); // O c�lculo necess�rio para que a velocidade e dire��o funcionem;

        if (direction.magnitude >= 0.1) //Isso influencia no controle da velocidade do player;
        {
            controller.Move(direction * speed * Time.deltaTime);
        }



        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            Vector3 playerToMouse = hit.point - transform.position;
            playerToMouse.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
            rb.MoveRotation (newRotation);
           
        }
       //Todo esse c�digo cria um ponto de luz, o qual o personagem seguir� apenas rotacionando o corpo;
    } 
}
