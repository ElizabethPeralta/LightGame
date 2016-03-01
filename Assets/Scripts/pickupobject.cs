using UnityEngine;
using System.Collections;

public class pickupobject : MonoBehaviour {

	Transform pickup;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {




		Ray ray = Camera.main.ScreenPointToRay( new Vector3(Screen.width* 0.5f, Screen.height* 0.5f, 0f) );
		RaycastHit rayHitInfo = new RaycastHit(); // generate var to hold hit data
		Debug.DrawRay( ray.origin, ray.direction * 4f, Color.yellow);
		// actually shoot the raycast
		if (pickup==null && Physics.Raycast( ray, out rayHitInfo, 4f ) ) {

			if (Input.GetMouseButtonDown (0)) {

				if (rayHitInfo.collider.tag == "Coin") {

					pickup = rayHitInfo.transform;

				}
			}

			// 			if ( Input.GetMouseButtonDown(0) ) { // 0 = left click, 1 = right click, 2 = middle
			// 				Debug.Log("MOUSE CURSOR IS OVER SOMETHING!");
			//                 
			//             }
			//                 //release object
			//             else if (Input.GetMouseButtonUp(0)){
			//            print("mouse button released");
			//            
			//            }
		} else if (pickup != null) {
			pickup.position = transform.position + transform.forward * 2f;
			//put drop code here
			if (Input.GetMouseButtonDown (0)) {
				pickup = null;

			}
		}


	}
}
