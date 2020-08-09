using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameDisplay : MonoBehaviour
{

    public TextMeshProUGUI foodNameText;

    public FoodManager foodManagerText;

    public static bool foodEaten = false;


    //public void SetName ()
	//{
		//foodNameText.text = foodManagerText.activeFood foodName;
	//}

	//public void RemoveLetter ()		// text dipindah ke depan conveyor, mungkin script baru
	//{
		//text.text = text.text.Remove(0, 1);
		//text.color = Color.yellow;
		//WordManager.conveyorText.text = text.text;
	//}

	//public void RemoveWord ()	// remove bakal dibagi 2, sampah dan poin
	//{
		//Destroy(gameObject);

		//foodEaten = true;
	//}
}
