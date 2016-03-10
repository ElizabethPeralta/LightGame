#pragma strict

   var target : Transform;

function Update () {

}

function OnTriggerEnter (col : Collider) {
if(col.gameObject.tag == "teleportXX") {
this.transform.position = target.position;

}
}

