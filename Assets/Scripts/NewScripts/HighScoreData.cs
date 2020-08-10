using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreData : MonoBehaviour
{
    public static HighScoreData instance;      // Singleton

    public int highScore;           

    // Functions //
    private void Awake()                    // Biar duluan klo ada proses lain yg pake void start
    {
        if (instance == null)               // Klo blom ada datanya
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Ditaro disini biar (mungkin) ga infinite loop
            Debug.Log("This is instance");
        }
        else                                // Klo udh ada datanya
        {
            Destroy(gameObject);
            Debug.Log("Destroyed instance");
        }
    }
}
