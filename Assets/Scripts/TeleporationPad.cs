using UnityEngine;
using System.Collections;

public class TeleporationPad : MonoBehaviour {

	//public GameObject player;
	public Transform spawnPoint;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
		void OnTriggerEnter (Collider col) {

			if (col.tag == "Player"){

				//player = col.transform.parent.gameObject.transform.parent.gameObject;
			col.transform.position = spawnPoint.transform.position;
			col.transform.rotation = spawnPoint.transform.rotation;
		}
	}
}
