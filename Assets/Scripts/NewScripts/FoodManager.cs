using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    public bool hasActiveFood;

    public GameObject activeFood;

    public FoodList foodListScript;

	public NameDisplay nameDisplayScript;

    public void TypeLetter (char letter)
	{
		if (hasActiveFood)
		{
            Food foodScript = activeFood.GetComponent<Food>();

            if (foodScript.WordTyped(nameDisplayScript))
		    {
			hasActiveFood = false;
			foodListScript.playerFoods.Remove(activeFood);
			Debug.Log("FoodTyped");
		    }

			else if (foodScript.GetNextLetter() == letter)
			{
				foodScript.TypeLetter(nameDisplayScript);
				Debug.Log("LetterTyped");
			}
		} else
		{
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
