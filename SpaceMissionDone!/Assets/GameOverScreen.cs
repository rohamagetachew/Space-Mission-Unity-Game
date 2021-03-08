using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
     public void Setup(int keepScore) {
        gameObject.SetActive(true);
        pointsText.text = keepScore.ToString() + "POINTS"; 
    }
}
