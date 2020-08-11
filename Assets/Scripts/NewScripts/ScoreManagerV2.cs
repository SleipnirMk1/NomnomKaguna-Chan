using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerV2 : MonoBehaviour
{
    public int playerScore;
    public int enemyScore;

    public int addScore = 10;

    public int highScore;

    //ublic WordDisplay wordDisplayScript;

    //private int previousScore = playerScore;

    [SerializeField]
	private TextMeshProUGUI scoreText;
    [SerializeField]
    private TextMeshProUGUI scoreEnemyText;

    // Start is called before the first frame update
    void Start()
    {
       highScore = HighScoreData.instance.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerScore.ToString();
        scoreEnemyText.text = enemyScore.ToString();
        
        if (FoodManager.foodEaten == true)
        {
            playerScore += addScore;
            FoodManager.foodEaten = false;
        }

        if (FoodManager.foodEnemyEaten == true)
        {
            enemyScore += addScore;
            FoodManager.foodEnemyEaten = false;
        }

         if (playerScore > highScore)
        {
            highScore = playerScore;
        } 
    }
}
