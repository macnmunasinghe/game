using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {

	public GameObject anim;

	void FixedUpdate () {
		anim.GetComponent<Animation>().Play();
		//anim.GetComponent<Animation>().Play(,PlayMode.StopAll);
	}
}
