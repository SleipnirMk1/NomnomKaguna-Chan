using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRandomizer : MonoBehaviour
{
    public List<GameObject> foodPrefabsList;

	public GameObject GetRandomFood ()
	{
		int randomIndex = Random.Range(0, foodPrefabsList.Count);
		GameObject randomFood = foodPrefabsList[randomIndex];

		return randomFood;
	}
}
