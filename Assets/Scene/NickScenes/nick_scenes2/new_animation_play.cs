using UnityEngine;
using System.Collections;

public class new_animation_play : MonoBehaviour {

	// Use this for initialization



	public Animator anim;


	void Start () {
		//anim.enabled = false;
	}

	void OnTriggerEnter () {
		anim.Play ("payOffParticles");

		//anim.enabled = true;
		//anim.GetComponent <ParticleSystem>().Play();
		Destroy(gameObject,1.5f);
	}

	void OnDestroy(){ 
		anim.Play ("defaultStatePayoff");
		//anim.enabled = false;
	} 

}
