//using UnityEngine;
//using System.Collections;
//
//public class SpaceBarTeleport : MonoBehaviour {
//	public GameObject[] teleportLoc;
//	public string tagName;
//	public int locIndex = 0;
//
//	//Timer
//	private float lastInterval;
//	private float elapsedTime;
//	private bool timerStarted;
//	private float waitTime = 1;
//	private bool keyPressed = false;
//
//
//	// Use this for initialization
//	void Start () {
//	
//		tagName = "Teleport";
//
//		//find and store all gameobjects with tag "Teleport"
//		teleportLoc = GameObject.FindGameObjectsWithTag(tagName);
//
//		//test print these locations
//		for(int 1=0; 1<teleportLoc.Length; 1++)
//			print ("Location:" + teleportLoc[1].transform.postion);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//		if (keyPressed){
//			keyPressed = false;
//
//		}
//
//		return;
//	}
//
//	if(Input.GetKey(KeyCode.Space))
//	{
//		locIndex++: //increment the location index
//
//		//make sure the index doesn't go over length of array
//		if (locIndex >= teleportLoc.Length) locIndex = 0;
//
//		//change location
//		transform.
//}
//