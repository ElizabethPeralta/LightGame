#pragma strict


var anim : Animator;
		

function Start () {
 anim.enabled = false;
}

function OnTriggerEnter () {

 anim.enabled = true;
 Destroy(gameObject);
}