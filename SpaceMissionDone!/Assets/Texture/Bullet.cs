using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   public float speed = 15f;
    Rigidbody2D r2d; 
    // Start is called before the first frame update
    void Start()
    {  
        r2d = GetComponent<Rigidbody2D>();

    // Make the bullet move upward
    r2d.velocity = new Vector2(0,speed);
}

// Function called when the object goes out of the screen
void OnBecameInvisible() {
    // Destroy the bullet 
    Destroy(gameObject);
}
void OnTriggerEnter2D(Collider2D col)
{
    if(col.gameObject.CompareTag("enemyobject"))
    {
        GameObject control = GameObject.Find("Canvas/Score"); // get game system object
        keepScore gc = control.GetComponent<keepScore>(); // get the script Score.cs from the object
        gc.Score++; // add 10 to players score
        gc.ScoreText.text = gc.Score.ToString();
    }

}

}
