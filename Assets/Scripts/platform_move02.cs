using UnityEngine;
using System.Collections;

public class platform_move02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	Vector3 floatY;
	public float number = 0.3f;

	void Update () {
		floatY = transform.position;
		floatY.y = (Mathf.Sin(Time.time) * number) + 1.5f;
		transform.position = floatY;
	}
}
