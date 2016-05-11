using UnityEngine;
using System.Collections;

public class FinalUltimateBestTriggerScriptEver : MonoBehaviour {

	// Use this for initialization


	public Renderer crystal;
	public Animator anim;


	void Start () {
		//anim.enabled = false;
	}

	void OnTriggerEnter (Collider col) {
		if (col.tag == "Player"){
			
		anim.Play ("payOffParticles");
			crystal.enabled = false; 

			GetComponent<AudioSource> ().Play ();

		//anim.enabled = true;
		//anim.GetComponent <ParticleSystem>().Play();
			Destroy(transform.parent.parent.gameObject,1.5f);}
	}

	void OnDestroy(){ 
		anim.Play ("defaultStatePayoff");
		//anim.enabled = false;
	} 

}
