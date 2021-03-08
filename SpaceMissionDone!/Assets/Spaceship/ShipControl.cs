using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public  GameManager gameManager;
	public GameObject bulletPrefab;
	public float speed = 10f;
	public float xLimit = 7;
    public float yLimit = 5; 
	public float reloadTime = 0.5f; 

	float elapsedTime = 0;

	void Update()
	{
		// Keeping track of time for bullet firing
		elapsedTime += Time.deltaTime;

		// Move the player left and right
		float xInput = Input.GetAxis("Horizontal");
		transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);

		//clamp the ship's x position
		Vector3 position = transform.position;
		position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
		transform.position = position;

       float yInput = Input.GetAxis("Vertical");
       transform.Translate(Vector3.up * yInput * Time.deltaTime * speed);

        Vector3 position1 = transform.position;
		position1.y = Mathf.Clamp(position1.y, -yLimit, yLimit);
		transform.position = position1;

		// Spacebar fires. The default InputManager settings call this “Jump”
		// Only happens if enough time has elapsed since last firing.
		if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
		{
			// Instantiate the bullet 1.2 units in front of the player
			Vector3 spawnPos = transform.position;
			spawnPos += new Vector3(0, 1.2f, 0);
			Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

			elapsedTime = 0f; // Reset bullet firing timer
		}
	}	
}
