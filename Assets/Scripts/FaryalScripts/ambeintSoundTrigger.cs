using UnityEngine;
using System.Collections;

public class  ambeintSoundTrigger : MonoBehaviour {

	void OnTriggerEnter( Collider col) {

	

		if (col.tag == "Player")
		{
			 
 	 		GetComponent<AudioSource> ().Play ();
		}


	}

}
