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


}