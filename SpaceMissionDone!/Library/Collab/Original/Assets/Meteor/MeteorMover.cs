using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class MeteorMover : MonoBehaviour
{
	public float speed = -2f;

	Rigidbody2D rigidBody;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		//Give meteor an initial downward velocity
		rigidBody.velocity = new Vector2(0, speed);
	}
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
*/
public class MeteorMover : MonoBehaviour {
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }
    //void OnBecameInvisible() {
         //Destroy(gameObject);
    // }

    // Update is called once per frame
     void Update () {
         if (OnBecameInvisible(rb)){
             Destroy(rb);
         }
      // if(transform.position.y < screenBounds.y * 1 ){
           // Destroy(this.gameObject);
           //OnBecameInvisible();
       // }
    }
}
