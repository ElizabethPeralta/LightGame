using UnityEngine;
using System.Collections;

public class trigger01 : MonoBehaviour {

		void OnTriggerEnter(Collider other) {

		if (visibileList == null) {
			visibleList = GameObject.FindGameObjectsWithTag ("Platform");

		}

				foreach (GameObject visible in visibleList) {
					visible.GetComponent<MeshRenderer>().enabled=true;




	
	}
	

}
}