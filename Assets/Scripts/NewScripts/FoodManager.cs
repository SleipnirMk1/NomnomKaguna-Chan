using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{

    public bool hasActiveFood;

	public static bool foodEaten;

	public static bool foodEnemyEaten;

    public GameObject activeFood;

    public FoodList foodListScript;

	public NameDisplay nameDisplayScript;

	public Animator playerAnimator;
	public Animator enemyAnimator;

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
		    		ProcessFood(activeFood, true);
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

	public void ProcessFood(GameObject food, bool isFoodEaten)
	{
		bool isPlayer = food.GetComponent<Food>().isPlayer;
		if(isPlayer)
		{
			Debug.Log("Player's food");
			hasActiveFood = false;
			foodListScript.playerFoods.Remove(food);
			Destroy(food);
			foodEaten = isFoodEaten;
			if(foodEaten)
			{
				playerAnimator.SetTrigger("PlayerEat");
			}	
		} else
		{
			Debug.Log("Enemy's food");
			foodListScript.enemyFoods.Remove(food);
			Destroy(food);
			foodEnemyEaten = isFoodEaten;
			if(foodEaten)
			{
				Debug.Log("Enemy eat");
				enemyAnimator.SetTrigger("EnemyEat");
			}
		}
	}
	
 
}
