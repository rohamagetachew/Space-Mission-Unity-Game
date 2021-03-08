using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    //public Collider2D other;

    public HealthBar HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }
    
    void OnTriggerEnter2D(Collider2D other)
     {
      if (other.gameObject.CompareTag("enemyobject"))
        {
         curHealth -= 10;
         HealthBar.SetHealth(curHealth);
        }
      if (other.gameObject.CompareTag("healthobject"))
        {
         curHealth += 10;
         HealthBar.SetHealth(curHealth);
        }
        if (curHealth == 0)
        {
           Destroy(gameObject);
           SceneManager.LoadScene("GameOverScreen");
        }

    } 

}
