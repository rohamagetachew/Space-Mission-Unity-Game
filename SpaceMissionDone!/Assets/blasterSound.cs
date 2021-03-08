using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blasterSound : MonoBehaviour
{
    public AudioSource someSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            someSound.Play();
        }
    }

}


