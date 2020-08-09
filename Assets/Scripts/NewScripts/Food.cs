using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

	public string foodName;

	public NameDisplay display;

	[SerializeField]
	private float beltSpeed = 3f;

	int nameIndex = 0;

	public char GetNextLetter ()
	{
		return foodName[nameIndex];
	}

	public void TypeLetter ()
	{
		nameIndex++;
		display.RemoveLetter();
	}

	public bool WordTyped ()
	{
		bool wordTyped = (nameIndex >= foodName.Length);
		if (wordTyped)
		{
			display.EatFood();
		}
		return wordTyped;
	}

	private void FixedUpdate()
	{
		transform.Translate(-beltSpeed * Time.deltaTime, 0f, 0f);
   }
}
