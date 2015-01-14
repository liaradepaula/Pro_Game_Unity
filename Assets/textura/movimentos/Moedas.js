#pragma strict

function Start () {

}

function Update () {
transform.Rotate(0,0,4);
}	

function OnTriggerEnter(other: Collider){

	Destroy(other.gameObject);
}