using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevitoCoin : MonoBehaviour
{
    public GameObject player;
    private BoxCollider coin;

    public GameObject pickUpSound;
    private GameObject newPickupSound;

    // Start is called before the first frame update
    void Start()
    {
        coin = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            newPickupSound = Instantiate(pickUpSound, transform.position, transform.rotation) as GameObject;
            Destroy(gameObject);
        }
    }
}
