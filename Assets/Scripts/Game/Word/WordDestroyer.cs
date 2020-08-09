using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDestroyer : MonoBehaviour
{

    public GameObject foodSprite;

    //public WordManager wordManager;

    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        WordManager.hasActiveWord = false;
        Destroy(gameObject);
        Debug.Log("Trigger");
    }
}
