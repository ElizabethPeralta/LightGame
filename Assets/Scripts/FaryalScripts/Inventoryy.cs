using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventoryy : MonoBehaviour {

	public List<Items> inventory = new List<Items>(); 
	private ItemDatabase database;
	// Use this for initialization
	void Start () {
		database = GameObject.FindWithTag ("ItemDatabase").GetComponent<ItemDatabase> ();
//		print (inventory.Count);
		inventory.Add(database.items [0]);
		inventory.Add(database.items [1]);

	
	}

	void OnGUI()
	{
		for(int i = 0; i < inventory.Count; i++)

		{
			GUI.Label (new Rect(10,i*20,200,50), inventory[i].itemName); 
		}

	}


}
