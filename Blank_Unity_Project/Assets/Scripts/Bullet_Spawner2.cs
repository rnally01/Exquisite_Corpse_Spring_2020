using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner2 : MonoBehaviour
{
    public GameObject projectile;
    private GameObject newProjectile;
    public Transform firePosition;
    public float bulletForce = 500F;
    private AudioSource Audio;
    [SerializeField] private AudioClip MainShoot;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");

        if (shoot)
        {
            Debug.Log("Firing left mouse click");

            
            newProjectile = Instantiate(projectile, firePosition.transform.position, firePosition.transform.rotation) as GameObject;
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * bulletForce);
            Audio.clip = MainShoot;
            Audio.Play();
        }
    }
}
