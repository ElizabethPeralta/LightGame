﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class startScreen : MonoBehaviour {

	// Use this for initialization
	 

	public void StartLevel()
	{
		SceneManager.LoadScene ("nc_terrain_fh 1");

	}
}
