using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim2 : MonoBehaviour {

	void FixedUpdate () {
		GetComponent<Animation>().Play("Ge_anim");
		GetComponent<Animation>().Play("Ge_anim",PlayMode.StopAll);
	}
}