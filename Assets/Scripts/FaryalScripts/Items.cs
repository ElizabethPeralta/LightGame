using UnityEngine;
using System.Collections;

[System.Serializable]
public class Items  {
	public string itemName;
	public int itemID;
	public string itemDescription;
	public Texture2D itemIcon;
	public int itemPower;
	public int itemSpeed;
	public ItemType itemType; 

	public enum ItemType {
		Lever,
	    Portal
	}

	public Items (string name, int id, string description, int power, int speed, ItemType type )

	{
		itemName = name;
		itemID = id;
		itemDescription = description;
		itemIcon = Resources.Load<Texture2D> ("Item Icons/" + name);
		itemPower = power;
		itemSpeed = speed;
		itemType = type; 
	}


}