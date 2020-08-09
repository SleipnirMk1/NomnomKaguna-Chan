using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterInput : MonoBehaviour
{
    public FoodManager foodManagerScript;

	// Update is called once per frame
	void Update () {
		foreach (char letter in Input.inputString)
		{
			foodManagerScript.TypeLetter(letter);
            //Debug.Log(letter);
		}
	}
}
