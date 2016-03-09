using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class Glide : MonoBehaviour {

	public ThirdPersonCharacter myCharacter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Space)) {
			myCharacter.m_GravityMultiplier = 0.2f;
		} else {

			myCharacter.m_GravityMultiplier = 2f;
		}

	
	}
}
