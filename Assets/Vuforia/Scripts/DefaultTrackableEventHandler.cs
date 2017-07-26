/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
		string[] ar = {"d","k","bk","ag","e","f","g","h","i","j","ck","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","aa","ab","ac","ad","ae","b","a","c","ad","cd","ak","al","am","an" };
		string[] ar1 = { "a", "c", "b", "a", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" };

		public GameObject bcimage;
		public GameObject bcimage1;

		public Text ts;
		public Text state;
		public Text melting;
		public Text bl;
		public Text rd;
		public Text dn;
		public Text ll;
		public Text kk;
		public Text lk;
		public Text aa;
		public Text ab;
		public Text ac;
		public Text ad;
		public Text ae;

		public static string trnm = "";

		public float scalingSpeed = 0.03f;//
		bool repeatScaleUp = false;
		bool repeatScaleDown = false;

		public GameObject sc;

		//public Button ahg;

		string path="";
		string jsonstring="";
		string scenename ="";

		public Plstat myPlstat = new Plstat();
		#region PRIVATE_MEMBER_VARIABLES
 
		private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES

		//public UserInterfaceButtons bs;

        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
			Scene scene = SceneManager.GetActiveScene ();
			scenename = scene.name;
			//ts.GetComponent<Text> ().font = Resources.GetBuiltinResource<Font> ("4u-ajantha.ttf");
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
			
				//path = Application.streamingAssetsPath+"/ss.txt";
				if (scenename == "atom_cam") {
					//sc.SetActive (false);
					TextAsset ff = Resources.Load ("ss") as TextAsset;
					jsonstring = ff.ToString ();
					//Debug.Log (jsonstring);

					Stat[] objects = JsonHelper.FromJson<Stat> (jsonstring);
					//Debug.Log (objects [0].elc.Length);
					//lk.text = (objects[0].elc[0]).ToString();
					//Debug.Log (lk.text);

				}
				if(scenename == "org_cam"){
					bcimage1.gameObject.SetActive (false);
					TextAsset ff = Resources.Load ("org") as TextAsset;
					jsonstring = ff.ToString ();
					//Debug.Log (jsonstring);
					Stat[] objects1 = JsonHelper.FromJson<Stat> (jsonstring);
					//Debug.Log (objects [index].elc [0];);
				}



            }
			bcimage.gameObject.SetActive (false);
			bcimage1.gameObject.SetActive (false);
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
			
			bcimage.gameObject.SetActive (true);
			bcimage1.gameObject.SetActive (true);
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }
			trnm = mTrackableBehaviour.TrackableName;
			//GameObject.FindWithTag ("Model").SetActive (true);
			Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found" );
			if (scenename == "atom_cam") {

				string nn = mTrackableBehaviour.TrackableName;
				//ScaleUpButton ();
				Track (nn);
				//bs.GetComponent="";
			}
			else if (scenename == "org_cam") {
				Invoke ("Offscan",0.2f);
				string nn = mTrackableBehaviour.TrackableName;
				TrackOrg (nn);
			}
        }


        private void OnTrackingLost()
        {
			//GameObject.FindWithTag ("Model").SetActive (false);
			sc.SetActive(true);
			//sc.GetComponent<Animation> ().Play ();

			if (bcimage.gameObject != null) {
				bcimage.gameObject.SetActive (false);
				bcimage1.gameObject.SetActive (false);
			}
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
			//Elements[] e = JsonUtility.FromJson<Elements[]> (jsonstring);
            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

			Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost" );
			try{
				//if(ts.gameObject != null){
					ts.text = "";
				//}
					state.text = "";
					melting.text = "";
					bl.text="";
					rd.text="";
					dn.text="";
					ll.text ="";
					kk.text = "";
					lk.text = "";
					aa.text="";
					ab.text = "";
					ac.text ="";
					ad.text = "";
					ae.text="";
				
			}
			catch(NullReferenceException ex){}

        }
		public void Track(string cc){
			Stat[] objects = JsonHelper.FromJson<Stat> (jsonstring);
			int index = Array.IndexOf<string> (ar, cc);
			//ts.GetComponent<Text> ().font = Resources.GetBuiltinResource<Font> ("4u-ajantha.ttf");
			ts.text= objects[index].name;//"Name : " +

			state.text ="State : " +  objects[index].State;
			melting.text = "Melting Point : " + objects[index].melting;
			bl.text = "Boilling Point : "  +objects [index].boilling;
			rd.text = "Radius : " +objects[index].rad;
			dn.text = "Density : " +objects[index].den;
			ll.text = objects [index].name;
			kk.text = objects [index].num;
			lk.text = (objects[index].elc[0]).ToString();
			//Debug.Log (objects [index].elc.Length);
			if (objects [index].elc.Length == 2) {
				aa.text = (objects [index].elc [1]).ToString ();
			} else if (objects [index].elc.Length == 3) {
				aa.text = (objects [index].elc [1]).ToString ();
				ab.text = (objects [index].elc [2]).ToString ();
			} else if (objects [index].elc.Length == 4) {
				aa.text = (objects [index].elc [1]).ToString ();
				ab.text = (objects [index].elc [2]).ToString ();
				ac.text = (objects [index].elc [3]).ToString ();
			} else if (objects [index].elc.Length == 5) {
				aa.text = (objects [index].elc [1]).ToString ();
				ab.text = (objects [index].elc [2]).ToString ();
				ac.text = (objects [index].elc [3]).ToString ();
				ad.text = (objects [index].elc [4]).ToString ();
			}else if(objects [index].elc.Length == 5){
				aa.text = (objects [index].elc [1]).ToString ();
				ab.text = (objects [index].elc [2]).ToString ();
				ac.text = (objects [index].elc [3]).ToString ();
				ad.text = (objects [index].elc [4]).ToString ();
				ae.text =  (objects[index].elc[5]).ToString();
			}

		}

		public void TrackOrg(string cc){
			bcimage1.gameObject.SetActive (false);
			Stat[] objects1 = JsonHelper.FromJson<Stat> (jsonstring);
			int index = Array.IndexOf<string> (ar1, cc);
			//Debug.Log (objects1 [index].Appearance);
			//print(e[0].ToString());
			ts.text="Name : " + objects1[index].name;
			ll.text="Formula : "+objects1 [index].formula;
			//ts.text = myPlstat.elements[0].name;//e.name;
			state.text ="Othername : " +  objects1[index].Othernames;
			melting.text = "Melting Point : " + objects1[index].melting;
			bl.text = "Boilling Point : "  +objects1 [index].boilling;
			dn.text ="Mass : "+ objects1 [index].mass;

			rd.text = "Density : " +objects1[index].den;
			//kk.text = "Appearance : "+objects1 [index].Appearance;;
		}

		public void ScaleUpButton ()
		{
			// transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
			GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);
		}
		public void ScaleDownButton ()
		{
			// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
			GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
		}

		private void Offscan(){
			sc.SetActive (false);
		}
        #endregion // PRIVATE_METHODS

    }

}
[System.Serializable]
public class Stat{
	//public string el1;
	public string name;
	public string State;
	public string melting;
	public string boilling;
	public string rad;
	public string den;
	public string Othernames;
	public string formula;
	public string mass;
	public string Appearance;
	public string elc;
	public string num;
}

[System.Serializable]
public class Plstat{
	public List <Stat> elements;
}