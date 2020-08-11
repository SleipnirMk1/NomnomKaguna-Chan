using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
	[SerializeField]
	private BoxCollider2D collider = null;
	[SerializeField]
	private FoodManager foodManager = null;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
    	if(col.tag.Equals("Food"))
    	{
    		foodManager.ProcessFood(col.gameObject, false);
    	}
    }
}
