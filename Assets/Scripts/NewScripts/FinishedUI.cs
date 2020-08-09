using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FinishedUI : MonoBehaviour
{

    public GameObject finishedCanvas; 

    public TextMeshProUGUI finalScoreText;
    
    private void Start ()
    {
        //finishedCanvas.SetActive(false);
    }

    private void Update()
    {

        if (CountDownTimer.levelFinished)
        {
            finishedCanvas.SetActive(true);

            finalScoreText.text = "Score: " + ScoreManagerV2.playerScore.ToString();
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene("Main");
    }

}
