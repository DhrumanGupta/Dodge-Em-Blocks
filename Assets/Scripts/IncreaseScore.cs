using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{

    public ScoreManager scoreManager;

    public void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Boulder"){
        scoreManager.increaseScore = true;
        }
    }
}
