using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    //private GameObject selectedFood;

    public FoodRandomizer foodRandomizerScript;

    public FoodList foodListScript;

    public bool isPlayer;

    public void SpawnFood()
	{
		float spawnY;
		if(isPlayer)
		{
			spawnY = 1f;
		} else
		{
			spawnY = -3f;
		}

        GameObject selectedFood = foodRandomizerScript.GetRandomFood();

		Vector3 randomPosition = new Vector3(12f, spawnY);

		GameObject foodObj = Instantiate(selectedFood, randomPosition, Quaternion.identity);
		//WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        foodListScript.playerFoods.Add(selectedFood);
	}
}
