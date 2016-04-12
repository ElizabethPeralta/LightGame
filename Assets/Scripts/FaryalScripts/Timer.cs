using UnityEngine;
using System.Collections;

public class Timer: MonoBehaviour {

	public float targetTime = 60.0f;

	void Update(){

		targetTime -= Time.deltaTime;

		if (targetTime <= 0.0f)
		{
			timerEnded();
		}

	}

	void timerEnded()
	{
		//do your stuff here.
	}


}