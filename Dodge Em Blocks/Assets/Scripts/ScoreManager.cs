using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int gameScore;
    public bool increaseScore;
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0;
        increaseScore = false;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
       if (increaseScore){
           gameScore = gameScore + 1;
           increaseScore = false;
       }
       scoreText.text = "Score : " + gameScore.ToString();
    }
}
