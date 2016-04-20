using UnityEngine;
using System.Collections;

public class characterParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider c ){

		if (c.gameObject.GetComponents<CharacterController>() != null ) {
			c.gameObject.transform.parent = this.gameObject.transform.parent;
		}
	}

	void OnTriggerExit( Collider c ){
		if (c.gameObject.GetComponents<CharacterController> () != null) {
			c.gameObject.transform.parent = null;
		}

	}
}
