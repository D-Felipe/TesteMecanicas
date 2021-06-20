using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Shooting shooting;
    [SerializeField] public CharacterController controller; // Essa linha aplica o controle do player;
    [SerializeField] float speed = 7f;  // Isso é a velocidade dele;
    RaycastHit hit;  // A variável necessária para o player olhar para onde o mouse for;
    Rigidbody rb;   // Uma variavel para criar o Rigidbody;
    public Transform playerTransform;
    public Vector3 direction;

    public HealthBarScript Healthbar;
    public int maxHealth =100;
    public int currentHealth;

    public int ammoitem;
    public int cura;

    void Start(){   
        currentHealth = maxHealth;
        Healthbar.SetMaxHealth(maxHealth);
    }
    
    public void TakeDamage(int damage){
        currentHealth -= damage;  
        Healthbar.SetHealth(currentHealth);
    }
    void OnCollisionEnter(Collision collisionInfo) //Ativa a detecção de colisão;
    {
        if(collisionInfo.gameObject.name == "Enemy") //Pega o nome do objeto com qual o player irá colidir;
        {
                   TakeDamage(20); 
           Debug.Log("Take Damage:"+currentHealth); // Texto que aparecerá no Console após colisão com o objeto;

          if(currentHealth<=0) 
          {
              Debug.Log("you died :(");  
          }
        }
    }
    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("life")){//esse aqui é o nosso item de vida
            currentHealth= currentHealth + cura;
            Healthbar.SetHealth(currentHealth);
             print("life recuperada:"+currentHealth);
            Destroy(collider.gameObject);
        }   
        // if(collider.CompareTag("ammo")){//esse aqui é o nossa bala
        //     currentHealth= currentHealth + cura;

        //      print("life recuperada:"+currentHealth);
        //     Destroy(collider.gameObject);
        // }       
     
    }
    void Update()
    {
        rb = GetComponent<Rigidbody>(); //Instanciamento do Rigidbody;
        float horizontal = Input.GetAxisRaw("Horizontal"); // Controle da Linha X (A,D);
        float vertical = Input.GetAxisRaw("Vertical");     // Controle da Linha Y (W,S);
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; // Permite se mover para horizontal, vertical e trava o Eixo Z;
        controller.Move(direction * speed * Time.deltaTime);
        controller.Move(direction * speed * Time.deltaTime); // O calculo necessario para que a velocidade e direcao funcionem;
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
       //Todo esse codigo cria um ponto de luz, o qual o personagem seguira apenas rotacionando o corpo;
    }
}
