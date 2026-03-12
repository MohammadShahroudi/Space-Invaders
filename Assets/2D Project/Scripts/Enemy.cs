using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
	// public AudioClip shootSound;
	AudioSource audioSource;
	public AudioClip explodeSound;

	public GameObject bulletPrefab;
    public Transform shootOffsetTransform;

	public AudioClip ticClip;
	public AudioClip tacClip;

    public delegate void EnemyDiedFunc(float points);
    public static event EnemyDiedFunc OnEnemyDied;
	public float score = 0f;
    
	void Start()
	{
		
	}

	void Awake()
    {
       audioSource = GetComponent<AudioSource>();
    }

	void Update()
	{
		// roll a random number
		// if that number is true then set can shoot
		// add a timer
		// then shoot the bullet prefab
		// set can shoot to false
		/*int randomNumber = UnityEngine.Random.Range();
		float timer = 0.0f;
		bool canShoot;
		int number;
		
		if (number == true)
		{
			timer += Time.deltaTime;
			canShoot = true;
		}
		canShoot = false;*/
		
	}

	// if an enemy gets hit then pause 
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
		audioSource.PlayOneShot(explodeSound);
        
        // todo - destroy the bullet
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            OnEnemyDied?.Invoke(score);
        }
        // todo - trigger death animation
    }

	public void PlayTicSound()
	{
		// Debug.Log("tic");
		GetComponent<AudioSource>().PlayOneShot(ticClip);	
	}

	public void PlayTacSound()
	{
		// Debug.Log("tac");
		GetComponent<AudioSource>().PlayOneShot(tacClip);	
	}
}
