using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool ballCollided = false;
    public static bool gamePaused = false;
    public GameObject pauseScreen;
    public GameObject Ball = null;
    public AudioSource ballHitAudio;
    public AudioSource ballWallHitAudio;
    public AudioSource scoreAudio;

    void Update()
    {
        if(ballCollided == true)
        {
            Invoke("createBall", 2f);
            ballCollided = false;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused == false)
            {
                pauseGame();
            }
            else if(gamePaused == true)
            {
                resumeGame();
            }
        }
    }
    void createBall()
    {
        Instantiate<GameObject>(Ball, new Vector3(0,0,0), Quaternion.identity);
    }
    public void ballHit()
    {
        ballHitAudio.Play();
    }
    public void ballWallHit()
    {
        ballWallHitAudio.Play();
    }

    public void ScoreSound()
    {
        scoreAudio.Play();
    }

    public void Player1()
    {
        SceneManager.LoadScene("Player1Won");
    }
    public void Player2()
    {
        SceneManager.LoadScene("Player2Won");
    }

    public void pauseGame()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    public void resumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void restartGame()
    {
        ScoreGameManager.score1 = 0;
        ScoreGameManager.score2 = 0;
        resumeGame();
        SceneManager.LoadScene("Level");
    }

    public void mainMenu()
    {
        ScoreGameManager.score1 = 0;
        ScoreGameManager.score2 = 0;
        resumeGame();
        SceneManager.LoadScene("MainMenu");
    }
}
