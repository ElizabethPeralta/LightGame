using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class timerScript : MonoBehaviour {
	Vector3 startLocation; 
	public Image timerImage;
	public float timeRemaining = 15.0f;


	// Use this for initialization
	void Start () {
		startLocation = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime; 
	//when no more time is left teleporting to the strtaing position
		//resetting timer

		if (timeRemaining <= 0f) {
			timeRemaining = 15f;
			transform.position = startLocation;

		}

		timerImage.fillAmount = timeRemaining / 15.0f;

	}
}
