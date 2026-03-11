using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour
{
	public AudioClip shootSound;
	AudioSource audioSource;

    public GameObject bulletPrefab;
    public Transform shootOffsetTransform;
	public float moveSpeed = 3.0f;

    void Start()
    {
        // todo - get and cache animator

        
    }

	void Awake()
    {
       audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
		float verticalInput = Input.GetAxis("Vertical");
        Vector3 upMovement = transform.up * verticalInput;
        transform.position += upMovement * moveSpeed * Time.deltaTime;

        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            Debug.Log("Bang!");
			audioSource.PlayOneShot(shootSound);

            // todo - destroy the bullet after 3 seconds
            Destroy(shot, 3f);
            
            // todo - trigger shoot animation
            GetComponent<Animator>().SetTrigger("Shot Trigger");
        }
		
		// if the player dies then go to the credits
		/*if ()
		{

		}*/
    }
}