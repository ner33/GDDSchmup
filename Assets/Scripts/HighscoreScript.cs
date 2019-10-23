using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour
{
    private int highscore;

    private Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscore = 0;

        highscoreText = GetComponent<Text>();

        highscoreText.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseHighscore(int points)
    {
        highscore = highscore + points;

        highscoreText.text = highscore.ToString();
    }

}
