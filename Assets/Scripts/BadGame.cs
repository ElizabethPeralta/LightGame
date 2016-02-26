using UnityEngine;
using System.Collections;

public class BadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (GameManager.useNightmareMode == true){
			GetComponents<Renderer> ().material.color = Color.red;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
