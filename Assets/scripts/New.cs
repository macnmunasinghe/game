using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;
namespace Vuforia
{
public class New : MonoBehaviour, ITrackableEventHandler {
		private TrackableBehaviour mTrackableBehaviour;

		string[] ar3 = {"a","b","c" };
		string[] or_ar = { "a","c" };

		public GameObject[] ghp;
		private int index;


		string scenename ="";

		public float scalingSpeed = 0.03f;
	// Use this for initialization
	void Start () {
			//Debug.Log(GameObject.FindGameObjectsWithTag ("Model"));
			Scene scene = SceneManager.GetActiveScene ();
			scenename = scene.name;
			Debug.Log(scenename);
			if (scenename == "atom_cam") {
				ghp = GameObject.FindGameObjectsWithTag ("Model");
			}
			else if(scenename == "org_cam"){
				ghp = GameObject.FindGameObjectsWithTag ("Ormodel");
				//Debug.Log(ghp[0]);
			}
		
	}
	
		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{

		}

		public void ScaleUpButton ()
		{
			string nm = DefaultTrackableEventHandler.trnm;
			//Debug.Log(nm);
			//if (OnTrackingFound()) {
			if (scenename == "atom_cam") {
				int index = Array.IndexOf<string> (ar3, nm);
				//Debug.Log(index);			
				ghp[index].transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);

			}
			else if (scenename == "org_cam") {
				int index = Array.IndexOf<string> (or_ar, nm);
				//Debug.Log(ghp[index]);			
				ghp[index].transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);

			}
		}

		public void ScaleDownButton ()
		{
			string nm = DefaultTrackableEventHandler.trnm;
			//Debug.Log(nm);
			//if (OnTrackingFound()) {
			if (scenename == "atom_cam") {
				int index = Array.IndexOf<string> (ar3, nm);
				//Debug.Log(index);			
				ghp [index].transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
			} else if (scenename == "org_cam") {
				int index = Array.IndexOf<string> (or_ar, nm);
				//Debug.Log(index);			
				ghp [index].transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
			}

		}

		/* 
		//void Update(){
			string nm = DefaultTrackableEventHandler.trnm;
			if (OnTrackingFound ()) {
			int index = Array.IndexOf<string> (ar3, nm);
		}
		void FixedUpdate () {
			//string nm = DefaultTrackableEventHandler.trnm;
			//if (OnTrackingFound ()) {
				//int index = Array.IndexOf<string> (ar3, nm);
				if (index >= 0) {
				//Debug.Log (index);
					ghp [index].GetComponent<Animation> ().Play ();
				} //else {
					//return;
				//}
			//}
			//anim.GetComponent<Animation>().Play(,PlayMode.StopAll);
		}

		*/

	}
}