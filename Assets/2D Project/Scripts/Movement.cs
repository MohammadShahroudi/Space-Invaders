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
	public float moveInterval = 3.0f;
	float timer = 0.0f;
    
    void FixedUpdate()
    {
		timer += Time.deltaTime;

		if (timer >= moveInterval)
		{
			timer = 0.0f;
			enemyStartPos = gameObject.transform.position;
        	Rigidbody enemyBody = GetComponent<Rigidbody>();
        	enemyBody.transform.position += new Vector3(0.5f, 0f, 0f);
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
