using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int playerScore;

    private int previousScore = playerScore;

    [SerializeField]
	private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        previousScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
