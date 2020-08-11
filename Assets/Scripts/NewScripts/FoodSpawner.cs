using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    //private GameObject selectedFood;

    public FoodRandomizer foodRandomizerScript;

    public FoodList foodListScript;

    public void SpawnFood()
	{
		//float spawnY;
		//if(isPlayer)
		//{
			//spawnY = 1f;
		//} else
		//{
			//spawnY = -3f;
		//}

        GameObject selectedFood = foodRandomizerScript.GetRandomFood();

		Vector3 randomPosition = new Vector3(10f, -1f);
		Vector3 randomEnemyPosition = new Vector3(-10f, -1f);

		GameObject foodObj = Instantiate(selectedFood, randomPosition, Quaternion.identity);
		GameObject foodEnemyObj = Instantiate(selectedFood, randomEnemyPosition, Quaternion.identity);
		//WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		foodObj.GetComponent<Food>().isPlayer = true;
		foodEnemyObj.GetComponent<Food>().isPlayer = false;
		foodEnemyObj.GetComponent<Food>().SetBeltSpeed();

        foodListScript.playerFoods.Add(foodObj);
        foodListScript.enemyFoods.Add(foodObj);
	}
}
