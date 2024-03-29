﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float startTime = 30f;

    public float currentTime;

    public TextMeshProUGUI countDownText;

    public static bool levelFinished;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        levelFinished = false;
        Time.timeScale = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownText.text = currentTime.ToString("F0");
        
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0f)
        {
            levelFinished = true;
            Time.timeScale = 0f;
        }
    }
}
