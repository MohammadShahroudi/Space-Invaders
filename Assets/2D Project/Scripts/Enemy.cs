using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using TMPro;

// [RequireComponent(typeof(Rigidbody2D))]
// [RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
	// public AudioClip shootSound;
	// AudioSource audioSource;

	public AudioClip ticClip;
	public AudioClip tacClip;

    public delegate void EnemyDiedFunc(float points);
    public static event EnemyDiedFunc OnEnemyDied;
	public float score = 0f;

	/*public GameObject bulletPrefab;
    public Transform shootOffsetTransform;
	public float moveSpeed = 3.0f;*/
    
	void Start()
	{
		
	}

	/*void Awake()
    {
       audioSource = GetComponent<AudioSource>();
    }*/

	void Update()
	{
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
        
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
