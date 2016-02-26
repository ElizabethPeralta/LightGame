using UnityEngine;
using System.Collections;

public class CubeBeliver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (0f, CubeGod.instance.godHappiness, 0f);
	}
}
