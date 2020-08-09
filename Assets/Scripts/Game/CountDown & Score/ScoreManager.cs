using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;

    public int addScore = 10;

    //ublic WordDisplay wordDisplayScript;

    //private int previousScore = playerScore;

    [SerializeField]
	private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    //void Start()
    //{
        //playerScore = 0;
    //}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerScore.ToString();
        
        if (WordDisplay.foodEaten == true)
        {
            playerScore += addScore;
            WordDisplay.foodEaten = false;
        }
    }
}
