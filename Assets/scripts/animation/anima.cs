using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour {
	/*
	void Start(){
		playanim ();
	}

	void playanim(){
		
		//GetComponent<Animation>().Play("anim");
	}*/

	void FixedUpdate () {
		GetComponent<Animation>().Play("As_anim");
		//GetComponent<Animation> ().Play ("Ge_anim");
		//Animation.Play ("As_anim");
		//Animation.Play ("As_anim",PlayMode.StopAll);
		GetComponent<Animation>().Play("As_anim",PlayMode.StopAll);

	}
}
