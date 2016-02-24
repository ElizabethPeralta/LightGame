using UnityEngine;
using System.Collections;

public class trigger01 : MonoBehaviour {

		void OnTriggerEnter(Collider other) {

		   gameObject.SetActive (true);
			gameObject.tag = "Platform"; 



	
	}
	

}
