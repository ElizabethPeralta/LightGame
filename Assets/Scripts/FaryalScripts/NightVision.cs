using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;


// if we can change to chnage the requirement to a key press?

[RequireComponent(typeof(AudioSource))]
public class NightVision : MonoBehaviour {

	public Light NightVisionLight;
	public string NightVisionButton = "NightVision";

	public AudioClip turnOnVision;
	public AudioClip turnOffVision;

	[HideInInspector]
	public bool pickedVision = false;
	private bool turnOn = false;
	private bool soundplayed = false;

	void FixedUpdate () {
		if(Input.GetButtonDown(NightVisionButton) && pickedVision){
			turnOn = !turnOn;
			soundplayed = false;
		}
	}

	void Update () {
		NoiseAndScratches NoiseEffect = this.GetComponent<NoiseAndScratches>();
		ColorCorrectionCurves NightVisionEffect = this.GetComponent<ColorCorrectionCurves>();
		if(turnOn){
			NoiseEffect.enabled = true;
			NightVisionEffect.enabled = true;
			NightVisionLight.enabled = true;
			if (!soundplayed) {
				this.GetComponent<AudioSource>().PlayOneShot(turnOnVision);
				soundplayed = true;
			}
		}

		if(!turnOn){
			NoiseEffect.enabled = false;
			NightVisionEffect.enabled = false;
			NightVisionLight.enabled = false;
			if (!soundplayed) {
				this.GetComponent<AudioSource>().PlayOneShot(turnOffVision);
				soundplayed = true;
			}
		}
	}
}
