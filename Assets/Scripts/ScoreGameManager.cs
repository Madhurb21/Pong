using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGameManager : MonoBehaviour
{
    public static int score1=0;
    public static int score2=0;
    public Text scorePlayer1;
    public Text scorePlayer2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorePlayer1.text = "" + ScoreGameManager.score1; 
        scorePlayer2.text = "" + ScoreGameManager.score2; 

        if(score1 >= WinningScore.winningScore)
        {
            FindObjectOfType<GameManager>().Player1();
        }
        if(score2 >= WinningScore.winningScore)
        {
            FindObjectOfType<GameManager>().Player2();
        }

    }
}
