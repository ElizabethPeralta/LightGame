using UnityEngine;
using System.Collections;

public class redPlatforms : MonoBehaviour {


	public Animator myAnimator; 


	// Use this for initialization
	void Start () {
		myAnimator.SetBool ("platformsSet", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B)) {
			myAnimator.SetBool ("platformsSet", true);
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			myAnimator.SetBool ("platformsSet", false);
		}
	
	}
		
}
