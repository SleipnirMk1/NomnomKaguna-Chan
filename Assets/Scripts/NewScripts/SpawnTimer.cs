using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public FoodSpawner foodSpawnerScript;

    public float foodDelay = 2f;
    private float nextFoodTime = 0.5f;

    private void FixedUpdate ()
    {
        if (Time.time >= nextFoodTime)
        {
            foodSpawnerScript.SpawnFood();
            nextFoodTime = Time.time + foodDelay;
        }
    }

}
