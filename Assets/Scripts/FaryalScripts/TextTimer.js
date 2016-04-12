#pragma strict

var timer: float = 10;

function Update()
{

	timer -= Time.deltaTime;

	if(timer <= 0)
	{
		timer = 0;

		//player respawns to starting point
	}

}

function OnGUI ()

{

	GUI.Label (new Rect(10,10,30,20), "" + timer.ToString("0"));

}