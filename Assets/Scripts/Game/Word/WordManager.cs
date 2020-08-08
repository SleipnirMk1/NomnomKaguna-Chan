using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> playerWords;
	public List<Word> enemyWords;

	public WordSpawner playerWordSpawner;
	public WordSpawner enemyWordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public void AddWord ()
	{
		Word playerWord = new Word(WordGenerator.GetRandomWord(), playerWordSpawner.SpawnWord());
		Word enemyWord = new Word(WordGenerator.GetRandomWord(), enemyWordSpawner.SpawnWord());
		
		Debug.Log("Player word: " + playerWord.word);
		Debug.Log("Enemy word: " + enemyWord.word);

		playerWords.Add(playerWord);
		enemyWords.Add(enemyWord);
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
