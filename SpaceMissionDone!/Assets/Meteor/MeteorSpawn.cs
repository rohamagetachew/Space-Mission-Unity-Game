using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//convert screen position to world's position
public class MeteorSpawn : MonoBehaviour {
    
    public GameObject Meteor; 
    Renderer renderer; 
    public float spawnTime = 2f;

void Start() {
    // Call the 'addEnemy' function in 0 second
    // Then every 'spawnTime' seconds
    InvokeRepeating("addEnemy", 0, spawnTime);
}

// New function to spawn an enemy
private void addEnemy() {
    // Get the renderer component of the spawn object
     var rd = GetComponent<Renderer>();

    // Position of the left edge of the spawn object
    // It's: (position of the center) minus (half the width)
    var x1 = transform.position.x - rd.bounds.size.x/2;

    // Same for the right edge
    var x2 = transform.position.x + rd.bounds.size.x/2;

    // Randomly pick a point within the spawn object
    var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

    // Create an enemy at the 'spawnPoint' position
    Instantiate(Meteor, spawnPoint, Quaternion.identity);
} 
    
    
}