using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void start(){
        inventory = new List<string>();
    }
    public List<string> inventory;
    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("collectable")){
        string itemType = collider.gameObject.GetComponent<ItemPickup>().itemType;
        print("PickUp:"+ itemType);
        inventory.Add(itemType);
        switch(inventory.Count){
            case 0:
            Debug.Log("aaaaaaa");
            break;
        }
        print("Inventory lenght:"+inventory.Count);
        Destroy(collider.gameObject);
        }         
    }
    void nsei()
    {
        
        
    }

}
