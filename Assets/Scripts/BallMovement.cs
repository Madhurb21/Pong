using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform ball;
    private float speed = Difficulty.ballSpeed;
    private float boundy = 0.1f;
    private Vector3 velocityBall = new Vector3(0,0,0);
    private float randValue;
    private bool ballReleased = false;
    private float paddleSize;
    private float paddleTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ball.Translate(velocityBall.normalized * Time.deltaTime * speed, Space.World);

        if(Input.GetKeyDown(KeyCode.Space) && !ballReleased)
        {
            randValue = Random.Range(-100f,100f);
            if(randValue > 0)
            {
                velocityBall = (new Vector3(1, (Random.Range(-boundy, boundy)), 0));
            }
            else
            {
                velocityBall = new Vector3(-1, (Random.Range(-boundy, boundy)), 0);
            }

            ballReleased = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player1")
        {
            paddleSize = other.bounds.size.y / 2;
            paddleTransform = other.transform.position.y;

            float velocityY = (ball.position.y - paddleTransform)/paddleSize;

            velocityBall = new Vector3(1, velocityY, 0);
            FindObjectOfType<GameManager>().ballHit();
        }
        else if(other.gameObject.tag == "player2")
        {
            paddleSize = other.bounds.size.y / 2;
            paddleTransform = other.transform.position.y;

            float velocityY = (ball.position.y - paddleTransform)/paddleSize;
            
            velocityBall = new Vector3(-1, velocityY, 0);
            FindObjectOfType<GameManager>().ballHit();
        }
        else if(other.gameObject.tag == "wall")
        {
            velocityBall = new Vector3(velocityBall.x, -velocityBall.y, 0);
            FindObjectOfType<GameManager>().ballWallHit();
        }
    }

}
