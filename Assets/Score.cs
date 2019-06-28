using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private float score = 0.0f;

    public static int result_score = 0;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 30;
    private int scoreToNextLevel = 10;
    
    public Text ScoreText;

    public static int GetScore()
    {
        return result_score;
    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (score >= scoreToNextLevel)
        {
            LevelUP();
        }
        score += Time.deltaTime;
        ScoreText.text = ("スコア："+(int)score).ToString();

        result_score = ((int)score);

	}

    void LevelUP()
    {
        if(difficultyLevel == maxDifficultyLevel)
        {
            return;
        }
        scoreToNextLevel *= 2;

        difficultyLevel++;

        GetComponent<corContllor>().SetSpeed(difficultyLevel);

        Debug.Log(scoreToNextLevel);

    }
}
