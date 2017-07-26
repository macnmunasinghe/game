using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ge_ani : MonoBehaviour {

	// Use this for initialization
	//private GameObject anim;

	void FixedUpdate () {
		gameObject.GetComponent<Animation> ().Play ();
		//anim.GetComponent<Animation>().Play();
		//anim.GetComponent<Animation>().Play(,PlayMode.StopAll);
	}
}
