using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    public bool hasActiveFood;

	public static bool foodEaten;

    public GameObject activeFood;

    public FoodList foodListScript;

	public NameDisplay nameDisplayScript;

    public void TypeLetter (char letter)
	{
		if (hasActiveFood)
		{
            Food foodScript = activeFood.GetComponent<Food>();
			if (foodScript.GetNextLetter() == letter)
			{
				foodScript.TypeLetter(nameDisplayScript);
				Debug.Log("LetterTyped");
			

            	if (foodScript.WordTyped(nameDisplayScript))
		    	{
					hasActiveFood = false;
					foodListScript.playerFoods.Remove(activeFood);
					Destroy(activeFood);
					foodEaten = true;
					Debug.Log("FoodTyped");
		    	}
			}
		
		} else
		{
			Debug.Log(foodListScript.playerFoods.Count);
			foreach(GameObject food in foodListScript.playerFoods)
			{
                Food foodScript = food.GetComponent<Food>();
				Debug.Log("SelectFood1");

				if (foodScript.GetNextLetter() == letter)
				{
					activeFood = food;
					nameDisplayScript.SetName();
					//text.text = activeWord.word;
					hasActiveFood = true;
					foodScript.TypeLetter(nameDisplayScript);
					Debug.Log("SelectFood2");
					break;
				}
			}
		}

		
	}
	
 
}
