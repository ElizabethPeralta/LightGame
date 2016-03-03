using UnityEngine;
using System.Collections;

public class platform_move04 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(Mathf.PingPong(Time.time,10.0f), transform.position.y, transform.position.z);
	
	}



	}

