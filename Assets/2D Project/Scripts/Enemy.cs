using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    // public AudioClip ticClip;
    // public AudioClip tacClip;

    public delegate void EnemyDiedFunc(float points);
    public static event EnemyDiedFunc OnEnemyDied;

	public Transform rightPoint;
	public Transform leftPoint;
	private Transform currentTarget;

	public float moveSpeed = 2f;
	public float waitTime = 1f;
	public float attackInterval = 3.0f;

	public GameObject bulletPrefab;
    public Transform shootOffsetTransform;

	public float score = 0f;

	private Rigidbody2D rb;
   
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
}
