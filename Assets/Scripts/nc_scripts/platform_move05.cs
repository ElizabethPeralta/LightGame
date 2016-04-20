using UnityEngine;
using System.Collections;

public class platform_move05 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(transform.position.x,(Mathf.PingPong(Time.time,1.0f)), transform.position.z);
	
	}
}
