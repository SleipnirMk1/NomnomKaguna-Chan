using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject foodPrefab;
	public Transform wordCanvas;

	public bool isPlayer;

	public WordDisplay SpawnWord()
	{
		float spawnY;
		if(isPlayer)
		{
			spawnY = 0f;
		} else
		{
			spawnY = -3f;
		}

		Vector3 randomPosition = new Vector3(12f, spawnY);

		GameObject wordObj = Instantiate(foodPrefab, randomPosition, Quaternion.identity, wordCanvas);
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		return wordDisplay;
	}

}
