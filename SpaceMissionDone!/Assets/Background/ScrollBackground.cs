using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
     public float speed = -2f;
     public float lowerYval = -20f;
     public float upperYval = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= lowerYval)
        {
            transform.Translate(0f, upperYval, 0f);
        }
        
    }
}
