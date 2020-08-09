using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    public bool hasActiveFood;

    public GameObject activeFood;

    public FoodList foodListScript;

    public void TypeLetter (char letter)
	{
		if (hasActiveFood)
		{
            Food foodScript = activeFood.GetComponent<Food>();

            if (foodScript.WordTyped())
		    {
			hasActiveFood = false;
			foodListScript.playerFoods.Remove(activeFood);
			Debug.Log("FoodTyped");
		    }

			else if (foodScript.GetNextLetter() == letter)
			{
				foodScript.TypeLetter();
				Debug.Log("LetterTyped");
			}
		} else
		{
			foreach(GameObject food in foodListScript.playerFoods)
			{
                Food foodScript = food.GetComponent<Food>();

				if (foodScript.GetNextLetter() == letter)
				{
					activeFood = food;
					//text.text = activeWord.word;
					hasActiveFood = true;
					foodScript.TypeLetter();
					Debug.Log("SelectFood");
					break;
				}
			}
		}

		
	}
 
}
