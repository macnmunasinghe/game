using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim3 : MonoBehaviour {

	void FixedUpdate () {
		GetComponent<Animation>().Play("Se_anim");
		GetComponent<Animation>().Play("Se_anim",PlayMode.StopAll);
	}
}
