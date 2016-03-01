using UnityEngine;
using System.Collections;

public class raycasting : MonoBehaviour {

	public Transform sphere; // assign in Inspector

	// Update is called for once per frame
	void Update () {
		// generates a Ray based on the mouse cursor pixel position on screen
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHitInfo = new RaycastHit (); //generate var to hold hit data

		// actually shoot the raycast
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) ) {
			if ( Input.GetMouseButtonDown (0) ) { // 0 = left click, 1 = right click, 2 = middle
				Debug.Log ("MOUSE CURSOR IS OVER SOMETHING!");
				Debug.DrawRay( ray.origin, ray.direction * 1000f, Color.yellow );
				sphere.position = rayHitInfo.point; // move sphere to where raycast hit

				Instantiate (sphere, rayHitInfo.point, Quaternion.identity); 


			
				

			}
		}
	}
}
