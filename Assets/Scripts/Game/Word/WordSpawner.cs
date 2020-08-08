using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject foodPrefab;
	public Transform wordCanvas;

	public WordDisplay SpawnWord ()
	{
		Vector3 randomPosition = new Vector3(12f, 0f);

		GameObject wordObj = Instantiate(foodPrefab, randomPosition, Quaternion.identity, wordCanvas);
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		return wordDisplay;
	}

}
