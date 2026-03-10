using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class Movement : MonoBehaviour
{
    // private Rigidbody rb;
    //private float startSpeed = 3f;
    // private float moveSpeed = 5f;
    // public Transform enemy;
    Vector3 enemyStartPos; 
    
    void FixedUpdate()
    {
        enemyStartPos = gameObject.transform.position;
        Rigidbody enemyBody = GetComponent<Rigidbody>();
        enemyBody.linearVelocity = new Vector3(1f, 0f, 0f) * 0.5f;
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
