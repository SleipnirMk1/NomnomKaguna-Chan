using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerV2 : MonoBehaviour
{
    public static int playerScore;

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
        
        if (FoodManager.foodEaten == true)
        {
            playerScore += addScore;
            FoodManager.foodEaten = false;
        }
    }
}
