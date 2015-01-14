using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("fire1")) {

			Application.LoadLevel("movimento");
				}
	
	}
}
