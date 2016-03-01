using UnityEngine;
using System.Collections;

public class color : MonoBehaviour {

	void Start(){
		gameObject.GetComponent<Renderer>().material.color =
			new Color (0.5f, 0.5f, 0.5f, 0.5f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.C)) {
			gameObject.GetComponent<Renderer>().material.color = Color.cyan;

			gameObject.GetComponent<Renderer>().material.color =
				new Color (0f, 1f, 1f, 0.5f);


		}

		if (Input.GetKeyDown (KeyCode.Y)) {
			gameObject.GetComponent<Renderer>().material.color = Color.yellow;

			gameObject.GetComponent<Renderer>().material.color =
				new Color (1f, 0.92f, 0.016f, 0.5f);

		} 
		if (Input.GetKeyDown (KeyCode.M)) {
			gameObject.GetComponent<Renderer>().material.color = Color.magenta;

			gameObject.GetComponent<Renderer>().material.color =
				new Color (1f, 0f, 1f, 0.5f);
			

		}
	
	}
}
