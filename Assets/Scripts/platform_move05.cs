using UnityEngine;
using System.Collections;

public class platform_move05 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time,10.0f));
	
	}
}
