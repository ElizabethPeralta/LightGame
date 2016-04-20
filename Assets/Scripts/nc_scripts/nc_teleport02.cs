//using UnityEngine;
//using System.Collections;
//
//public class nc_teleport02 : MonoBehaviour {
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//
//	void OnTriggerEnter(Collider Portal)
//	{
//		PortalComponent p = Portal.gameObject.GetComponent<PortalComponent>();
//
//		if (p != null) {
//			Debug.Log ("teleporting");         
//
//			gameObject.transform.position = p.Destination;    
//		}
//	}
//}
