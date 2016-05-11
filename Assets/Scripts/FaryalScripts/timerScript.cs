using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class timerScript : MonoBehaviour {
	Vector3 startLocation; 
	public Image timerImage;
	public float timeRemaining = 30.0f;
	IEnumerator fade(){

		ScreenFade.Fade (Color.white, 0f, 1f, 2f, 0f, true);
		yield return new WaitForSeconds (2f);
		transform.position = startLocation;
		ScreenFade.Fade (Color.white, 1f, 0f, 2f, 0f, false);


	}


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
			timeRemaining = 50.0f;
			transform.position = startLocation;
			StartCoroutine (fade());
		}

		timerImage.fillAmount = timeRemaining / 50.0f;

	}
}
