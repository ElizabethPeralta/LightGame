﻿using UnityEngine;
using System.Collections;

public class object_float : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (30, 30, 0) * Time.deltaTime);
	
	}
}
