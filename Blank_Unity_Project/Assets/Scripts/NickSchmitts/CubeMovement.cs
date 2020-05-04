using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    Rigidbody rb;
    Transform player;
    Transform shootPos;
    public GameObject bullet;
    public bool belAir = false;
    public float jumpHeight = 100;
    public float bulletSpeed = 10;
    public float fireRate = 3f;
    public float nextFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        shootPos = transform.GetChild(0).transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.LookAt(player);
        if (!belAir) 
        {
            Jump();
        }
        if (Time.time > nextFire) 
        {
            nextFire = Time.time + fireRate;
            ShootDelayed();
        }
        if (transform.position.y < -4f) 
        {
            Destroy(gameObject);
        }
    }

    private void Jump() 
    {
        belAir = true;
        rb.AddForce(new Vector3(0,jumpHeight,0));
    }
    private void OnCollisionStay(Collision collision)
    {
        belAir = false;
    }
    private void ShootDelayed()
    { 
        GameObject temp = Instantiate(bullet, shootPos.position, shootPos.rotation);
        temp.GetComponent<Rigidbody>().velocity = shootPos.forward * bulletSpeed;
    }

}
