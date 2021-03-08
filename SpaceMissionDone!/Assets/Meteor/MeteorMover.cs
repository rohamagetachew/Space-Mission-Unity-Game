using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMover : MonoBehaviour
{
    // Public variable that contains the speed of the enemy
public float speed = -5f;
Rigidbody2D r2d; 
public  GameManager GameManager;

// Function called when the enemy is created
void Start () {
    // Get the rigidbody component
     r2d = GetComponent<Rigidbody2D>();

    // Add a vertical speed to the enemy
    r2d.velocity = new Vector2 (0,speed);

}

 
// Function called when the object goes out of the screen
void OnBecameInvisible() {
    // Destroy the enemy
    Destroy(gameObject);
}

void OnTriggerEnter2D(Collider2D other) {
    // Name of the object that collided with the enemy
    var name = other.gameObject.name;

    // If the enemy collided with a bullet
    if (name == "bullet(Clone)") {
        // Destroy itself (the enemy) and the bullet
        Destroy(gameObject);
        Destroy(other.gameObject);    
    }
    // If the enemy collided with the spaceship
    if (name == "bgbattleship_0") {
        // Destroy itself (the enemy) to keep things simple
        Destroy(gameObject);
    }

} 

}

