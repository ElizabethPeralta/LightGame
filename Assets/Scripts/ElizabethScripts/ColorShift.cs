
using UnityEngine;
using System.Collections;

public class ColorShift : MonoBehaviour
{
	public float hue = 0f;
	public float saturation = 1f;
	public float brightness = 1f;

	private Light lt;
	private HSBColor col;

	// Use this for initialization
	void Start()
	{
		// setup components
		lt = GetComponent<Light>();
		// setup hsb color
		col = new HSBColor(hue, saturation, brightness);
	}

	// Update is called once per frame
	void Update()
	{
		// move through the hue range
		col.h += 0.1f * Time.deltaTime;

		// if at hue max, reset to zero
		if (col.h > 1.0f)
		{
			col.h = 0.0f;
		}

		// update light color with converted HSB color
		lt.color = col.ToColor();
	}
}