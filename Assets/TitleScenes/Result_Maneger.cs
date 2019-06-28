using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result_Maneger : MonoBehaviour {

    private int result_score = 0;

    public Text ScoreText;

    private int count = 0;

    // Use this for initialization
    void Start ()
    {
        this.result_score = Score.GetScore();
    }
	
	// Update is called once per frame
	void Update ()
    {
        count++;

        if(count == 600|| Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }


        this.ScoreText.text = "最終スコア："+ result_score.ToString();
 
    }
}
