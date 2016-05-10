using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class startScreen : MonoBehaviour {

	// Use this for initialization
	 

	public void StartLevel()
	{

		//float fadeTime = GameObject.Find ("NewPlayerWithPayOffAgain").GetComponent<Fading> ().BeginFade (1);
		//yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("nc_terrain_fh 1");

	}
}
