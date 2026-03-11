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

	// enemyAmount is 17
	// public int enemyAmount = 17;

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
		// roll a random number
		// if that number is true then set can shoot
		// add a timer
		// then shoot the bullet prefab
		// set can shoot to false
	}

	// if an enemy get hit then pause 
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
		StartCoroutine(Pause(collision));
        
        // todo - destroy the bullet
        if (collision.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            OnEnemyDied?.Invoke(score);
        }
        // todo - trigger death animation
    }

	public IEnumerator Pause(Collision2D enemies)
	{
		yield return new WaitForSeconds(5f);
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
