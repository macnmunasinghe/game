using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour {

	public static Gamemanager Instance{ set; get;}

	private void Awake(){
		Instance = this;
		DontDestroyOnLoad (this.gameObject);

		ChangeScene ("main_menu");
	}
	public void ChangeScene(string sceneName){
		SceneManager.LoadScene (sceneName);

	}
}
