using UnityEngine;
using System.Collections;

public class trigger_cube : MonoBehaviour {

	public Animator myAnimator;

	// Use this for initialization
	void Start () {

		myAnimator.SetBool ("MakeBridge", false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		myAnimator.SetBool ("MakeBridge", true);
	}
}
