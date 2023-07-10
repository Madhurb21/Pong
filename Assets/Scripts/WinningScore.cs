using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int winningScore = 7;
    public Text winningScoreNumber;

    public void rightButtonClicked()
    {
        if(winningScore < 21)
        {
            winningScore++;
        }
    }
    public void leftButtonClicked()
    {
        if(winningScore > 1)
        {
            winningScore--;
        }
    }

    private void Update()
    {
        winningScoreNumber.text = "" + winningScore;
    }
}
