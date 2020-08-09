using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordManager : MonoBehaviour {

	public List<Word> playerWords;
	public List<Word> enemyWords;

	public WordSpawner playerWordSpawner;
	public WordSpawner enemyWordSpawner;

	//public TextMeshProUGUI text;

	public static bool hasActiveWord;
	private Word activeWord;

	//public static TextMeshProUGUI conveyorText;

	public void AddWord ()
	{
		Word playerWord = new Word(WordGenerator.GetRandomWord(), playerWordSpawner.SpawnWord());
		//Word enemyWord = new Word(WordGenerator.GetRandomWord(), enemyWordSpawner.SpawnWord());
		
		Debug.Log("Player word: " + playerWord.word);
		//Debug.Log("Enemy word: " + enemyWord.word);

		playerWords.Add(playerWord);
		//enemyWords.Add(enemyWord);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();

			}
		} else
		{
			foreach(Word word in playerWords)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					//text.text = activeWord.word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			playerWords.Remove(activeWord);
		}
	}

}
