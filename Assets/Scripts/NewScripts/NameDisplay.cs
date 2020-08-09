using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameDisplay : MonoBehaviour
{

    public TextMeshProUGUI foodNameText;

    public FoodManager foodManagerScript;

    public bool foodEaten;


    public void SetName ()
	{
		Food foodScript = foodManagerScript.activeFood.GetComponent<Food>();
		foodNameText.text = foodScript.foodName;
		Debug.Log("SetName");
	}

	public void RemoveLetter ()		// text dipindah ke depan conveyor, mungkin script baru
	{
		foodNameText.text = foodNameText.text.Remove(0, 1);
		foodNameText.color = Color.yellow;
		//WordManager.conveyorText.text = text.text;
	}

	public void EatFood ()	// remove bakal dibagi 2, sampah dan poin
	{
		Destroy(gameObject);

		foodEaten = true;
	}
}
