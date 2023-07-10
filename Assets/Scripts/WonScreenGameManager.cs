using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonScreenGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreGameManager.score1 = 0;
        ScoreGameManager.score2 = 0;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level");
        ScoreGameManager.score1 = 0;
        ScoreGameManager.score2 = 0;
    }
}
