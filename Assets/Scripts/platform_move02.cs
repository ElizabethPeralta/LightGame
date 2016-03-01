using UnityEngine;
using System.Collections;

public class platform_move02 : MonoBehaviour {

	public float amplitude = 0.5f;
	 

	// Use this for initialization
	void Start () {
	
	}

	Vector3 floatY;
	public float number = 0.3f;

	void Update () {
		floatY = transform.position;
		floatY.y = (Mathf.Sin(Time.time * 0.4f) * amplitude) + 1.5f;
		transform.position = floatY;
	}
}
