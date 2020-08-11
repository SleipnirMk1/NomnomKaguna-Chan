using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

	// Collider of Enemy's Eat Area
	// Checking will only be done IF the food is inside the area
    private BoxCollider2D eatArea;

    [SerializeField]
    private FoodManager foodManager;

    #region Difficulty Variables
    [Range(0f, 1f)]
    public float eatChance;		// The chance of the food inside being eaten
    
    // Delay between checks
    // In each check, a random value will be generated and considered against eatChance;
    public float checkDelay;

    public float eatAreaSize;	// The width of eat area

    #endregion

    private float currentCheckTime;
    public bool isInsideCheckingArea = false;
    public bool isChecking = false;
    public Food currentFood = null;


    void Start()
    {
    	eatArea = GetComponent<BoxCollider2D>();
    	currentCheckTime = checkDelay;
    	eatArea.size = new Vector2(eatAreaSize, eatArea.size.y); // This will set the width of check area
    }

    void OnTriggerStay2D(Collider2D col)
    {	

    	if(col.tag.Equals("Food"))	// Checks if the colliding object is a Food by its Tag
    	{	
    		// Checks if the minimum and maximum X of the food is inside the collider
    		if(eatArea.bounds.min.x < col.bounds.min.x && eatArea.bounds.max.x > col.bounds.max.x)
    		{
    			// This is like the active food of player
    			// If there is no active food, then the colliding one will be considered active
    			// By any chance, there are 2 food objects in the collider, this prevents from alternating between food
    			// Choosing only the first food until it is null
    			if(currentFood == null)
    			{
    				currentFood = col.GetComponent<Food>();
    			}
    			isInsideCheckingArea = true;
  				if(isChecking)
  				{
    				DetermineEatFood(currentFood);
    				isChecking = false;
  				}
    		}
    	}
    }

    void OnTriggerExit2D(Collider2D col)
    {
    	// Initialize back the variables
    	// If a food is not eaten, it will be ignored
    	currentFood = null;
    	isInsideCheckingArea = false;
    	isChecking = false;
    }

    private void DetermineEatFood(Food enemyFood)
    {
    	float randomValue = Random.Range(0f, 1f);

    	if(randomValue < eatChance)
    	{
    		foodManager.ProcessFood(enemyFood.gameObject, true);
    		currentFood = null;
    		isInsideCheckingArea = false;
    		isChecking = false;
    	}
    }

    private void Update()
    {
        if(isInsideCheckingArea)
        {
        	currentCheckTime -= 1 * Time.deltaTime;

	        if (currentCheckTime <= 0f)
	        {
	            isChecking = true;
	            currentCheckTime = checkDelay;
	        }
        }
    }

}
