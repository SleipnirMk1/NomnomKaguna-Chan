using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour {

	public TextMeshProUGUI text;
	
	public float foodSpeed = 1f;
	public static bool foodEaten = false;
	//public GameObject sprite;

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()		// text dipindah ke depan conveyor, mungkin script baru
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.yellow;
		//WordManager.conveyorText.text = text.text;
	}

	public void RemoveWord ()	// remove bakal dibagi 2, sampah dan poin
	{
		Destroy(gameObject);

		foodEaten = true;
	}

	private void FixedUpdate()
	{
		transform.Translate(-foodSpeed * Time.deltaTime, 0f, 0f);
	}

}
