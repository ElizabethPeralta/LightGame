using UnityEngine;
using System.Collections;

public class platform_move03 : MonoBehaviour {

	public float amplitude = 0.5f;
	public float frequency = 20f;
	 

	// Use this for initialization
	void Start () {
	
	}

	Vector3 floatX;
	public float number = 0.3f;

	void Update () {
		floatX = transform.position;
		floatX.x = (Mathf.Sin(Time.time * 2f) * amplitude) + 1.5f;
		transform.position = floatX;
	}



}
