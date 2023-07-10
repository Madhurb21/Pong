using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ballSpeed = 11 ;
    public Text difficultyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballSpeed == 11)
        {
            difficultyText.text = "Medium";
            Movement.speed = 10;
        }
        if(ballSpeed == 15)
        {
            difficultyText.text = "Hard";
            Movement.speed = 10;
        }
        if(ballSpeed == 8)
        {
            difficultyText.text = "Easy";
            Movement.speed = 10;
        }
        if(ballSpeed == 20)
        {
            difficultyText.text = "Insane";
            Movement.speed = 15;
        }
    }

    public void rightButton()
    {
        if(ballSpeed == 8)
            ballSpeed = 11;
        else if(ballSpeed == 11)
            ballSpeed = 15; 
        else if(ballSpeed == 15)
            ballSpeed = 20;
    }

    public void leftButton()
    {
        if(ballSpeed == 20)
            ballSpeed = 15;
        else if(ballSpeed == 15)
            ballSpeed = 11; 
        else if(ballSpeed == 11)
            ballSpeed = 8;
    }
}
