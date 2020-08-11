using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Food : MonoBehaviour
{

	public string foodName;

	[SerializeField]
	private float beltSpeed = 3f;

	private int nameIndex = 0;

	public bool isPlayer;

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

	public void SetBeltSpeed()
	{
		if(!isPlayer)
		{
			beltSpeed = beltSpeed / 2;
		}	
	}

	private void FixedUpdate()
	{
		if(isPlayer)
		{
			transform.Translate(-beltSpeed * Time.deltaTime, 0f, 0f);
		} else
		{
			transform.Translate(beltSpeed * Time.deltaTime, 0f, 0f);

		}
   }
}
