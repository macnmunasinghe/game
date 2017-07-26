using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menumanager : MonoBehaviour {

	public void OnARButtonClick(){
		Gamemanager.Instance.ChangeScene ("ar_menu");
	}
	public void OnGAMEButtonClick(){
		Gamemanager.Instance.ChangeScene ("game_menu");
	}
	public void OnTIPSButtonClick(){
		Gamemanager.Instance.ChangeScene ("abc1");
	}
	public void OnBackButtonClick(){
		Gamemanager.Instance.ChangeScene ("main_menu");
	}
	public void OnBackButtonClick1(){
		Gamemanager.Instance.ChangeScene ("ar_menu");
	}

	public void OnTABLEButtonClick(){
		Gamemanager.Instance.ChangeScene ("atom_cam");
	}
	public void OnORGANICButtonClick(){
		Gamemanager.Instance.ChangeScene ("org_cam");
	}
	public void OnHYBRIDButtonClick(){
		Gamemanager.Instance.ChangeScene ("atom_cam");
	}
	public void OnMainMenuButtonClick(){
		Gamemanager.Instance.ChangeScene ("main_menu");
	}

	public void  OnExitButtonClick () {

		Application.Quit();

	}
}
