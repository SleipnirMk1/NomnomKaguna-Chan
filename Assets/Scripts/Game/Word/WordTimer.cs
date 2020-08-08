using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;

	public float wordDelay = 1f;
	private float nextWordTime = 0.5f;

	private void Update()
	{
		if (Time.time >= nextWordTime)
		{
			wordManager.AddWord();
			nextWordTime = Time.time + wordDelay;
			//wordDelay *= .99f;
		}
	}

}
