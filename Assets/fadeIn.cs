using UnityEngine;
using System.Collections;

public class fadeIn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		ScreenFade.Fade (Color.white, 1f, 0f, 1f, 0f, true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
