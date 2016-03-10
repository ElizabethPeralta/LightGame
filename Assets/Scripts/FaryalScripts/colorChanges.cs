using UnityEngine;
using System.Collections;

namespace Chapter1
{
public class colorChanges : MonoBehaviour 
	 
{ 
	public void SetLayerToNotSold()
	{
		gameObject.layer = LayerMask.NameToLayer("not solid");
		GetComponent<Renderer>().material.color = Color.green;

	}

	public void SetLayerToDefault()
	{
		gameObject.layer = LayerMask.NameToLayer("default");
		GetComponent<Renderer>().material.color = Color.white;


			}

	         }
}