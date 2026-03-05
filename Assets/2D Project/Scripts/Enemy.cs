using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    // public AudioClip ticClip;
    // public AudioClip tacClip;

    public delegate void EnemyDiedFunc(float points);
    public static event EnemyDiedFunc OnEnemyDied;
	public float score = 0f;
    
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
