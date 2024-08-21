using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    //public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        //instanciar o tiro na posi��o do player e com a rota��o padr�o
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position,firePoint.rotation);

        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
