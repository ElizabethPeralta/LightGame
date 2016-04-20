using UnityEngine;
using System.Collections;

public class finalGainingTime : MonoBehaviour {

	void OnTriggerEnter( Collider col) {

	

		if (col.tag == "Player")
		{
			col.GetComponent<timerScript> ().timeRemaining += 5f;
			Debug.Log ("should be working");

		}


	}

}
