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

    public TextMeshProUGUI highScoreText;

    public GameObject scoreManager;
    

    private void Update()
    {
        if (CountDownTimer.levelFinished)
        {
            finishedCanvas.SetActive(true);

            ScoreManagerV2 scoreManagerScript = scoreManager.GetComponent<ScoreManagerV2>();

            finalScoreText.text = " Your Score: " + scoreManagerScript.playerScore.ToString();

            HighScoreData.instance.highScore = scoreManagerScript.highScore;

            highScoreText.text = "High Score:" + scoreManagerScript.highScore.ToString();
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene("Main");
    }

}
