using UnityEngine;
using System.Collections;

public class trailMoveScript : MonoBehaviour {

	public float moveForce;
	public float jumpforce;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float h = Input.GetAxis ("Horizontal") * moveForce;
		float v = Input.GetAxis ("Verical") * moveForce;

		GetComponent<Rigidbody>().AddForce (new Vector3 (h, 0, v));

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce (Vector3.up * jumpforce);

		}
			


	}
}
