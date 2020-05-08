using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{
    public GameObject projectile;
    private GameObject newProjectile;
    public GameObject box;
    private GameObject newbox;
    public Transform firePosition;
    public float bulletForce = 500F;

    // Update is called once per frame
    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");
        bool deploy = Input.GetButtonDown("Fire2");

        if (shoot)
        {
            Debug.Log("Firing left mouse click");

            newProjectile = Instantiate(projectile, firePosition.transform.position, firePosition.transform.rotation) as GameObject;
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
        }

        if (deploy)
        {
            Debug.Log("Firing right mouse click");

            newbox = Instantiate(box, firePosition.transform.position, firePosition.transform.rotation) as GameObject;
        }
    }
}
