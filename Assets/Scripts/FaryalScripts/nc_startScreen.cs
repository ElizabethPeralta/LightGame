using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class nc_startScreen : MonoBehaviour {

	// Use this for initialization
	 

	public void StartLevel()
	{
		SceneManager.LoadScene ("nc_duplicate");

	}
}
