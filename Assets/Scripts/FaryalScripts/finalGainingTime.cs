﻿using UnityEngine;
using System.Collections;

public class finalGainingTime : MonoBehaviour {

	void OnTriggerEnter( Collider col) {

	

		if (col.tag == "Player")
		{
			col.GetComponent<timerScript> ().timeRemaining += 40f;
			Debug.Log ("should be working");

 	 		GetComponent<AudioSource> ().Play ();
		}


	}

}
