using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletDie : MonoBehaviour
{
    private GameObject TeleportationPoint;
    private AudioSource Audio;
    [SerializeField] private AudioClip BoxBullyHit;
	private void Start()
	{
		Audio = GetComponent<AudioSource>();
	}

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "BullyBox")
        {
            Audio.clip = BoxBullyHit;
            Audio.Play();
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
