using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdatedScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdatedScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int value)
    {
        score += value;
        UpdatedScore();
    }
}
