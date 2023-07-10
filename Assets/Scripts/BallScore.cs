using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{
    private int scoreInc = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "scorePlayer2")
        {
            ScoreGameManager.score2 += scoreInc;
            FindObjectOfType<GameManager>().ScoreSound();
            Invoke("DestroyBall", 1f);
            GameManager.ballCollided = true;
        }
        if(other.gameObject.tag == "scorePlayer1")
        {
            ScoreGameManager.score1 += scoreInc;
            FindObjectOfType<GameManager>().ScoreSound();
            Invoke("DestroyBall", 1f);
            GameManager.ballCollided = true;
        }
    }

    void DestroyBall()
    {
        Destroy(this.gameObject);
    }
}
