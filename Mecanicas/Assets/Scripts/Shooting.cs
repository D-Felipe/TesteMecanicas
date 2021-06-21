using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public int maxAmmo=8;
    int currentAmmo;
    public float reloadTime=0.2f;
    bool isReloading = false;

    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletForce;

   void Start(){
       currentAmmo = maxAmmo;
   }
    void Update()
    {
        if(isReloading)
        return;
       
        if(currentAmmo <=0){
            StartCoroutine(Reload());
            return;
        }
        if(MenuController.GameIsPaused == false){
        if(Input.GetButtonDown("Fire1"))
        {

            Shoot();
        }
        }
    }

    void Shoot()
    {
        currentAmmo--;
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode.Impulse);
        Destroy(Bullet, 1.0f);
    }
    IEnumerator Reload(){
        if(Input.GetKeyDown(KeyCode.R)){
        isReloading=true;
        Debug.Log("Reloading");
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
        }
    }
}
