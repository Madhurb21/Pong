using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuGameManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void gameOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void credits()
    {
        SceneManager.LoadScene("Controls");
    }
}
