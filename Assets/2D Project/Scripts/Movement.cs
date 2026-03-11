using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class Movement : MonoBehaviour
{
    Vector3 enemyStartPos; 

	// enemyAmount is 17
	public int enemyAmount = 17;
    
    void FixedUpdate()
    {
		
        enemyStartPos = gameObject.transform.position;
        Rigidbody enemyBody = GetComponent<Rigidbody>();
        enemyBody.linearVelocity = new Vector3(1f, 0f, 0f) * 0.5f;
		
    }

	// if an enemy get hit then
	// decrement enemyAmount
	// if enemyAmount == 0 then All Enemies Dead!
	void OnCollision2D(Collision2D collision)
	{
		if (enemyAmount == 0)
		{
			Debug.Log("All Enemies Dead!");
		}
		if (collision.gameObject)
        {
			enemyAmount--;
        }
	}
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
