using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

	public string foodName;

	[SerializeField]
	private float beltSpeed = 3f;

	private int nameIndex = 0;

	public char GetNextLetter ()
	{
		return foodName[nameIndex];
	}

	public void TypeLetter (NameDisplay display)
	{
		nameIndex++;
		display.RemoveLetter();
	}

	public bool WordTyped (NameDisplay display)
	{
		bool wordTyped = (nameIndex >= foodName.Length);
		
		return wordTyped;
	}

	private void FixedUpdate()
	{
		transform.Translate(-beltSpeed * Time.deltaTime, 0f, 0f);
   }
}
