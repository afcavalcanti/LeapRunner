using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public static bool Pitch = false;
	public static bool Yaw = false;
	public static bool Roll = false;
	public static bool X = false;
	public static bool Grab = false;
	public static bool Mao = false;

	public void SelectX(){
		X = true;
	}
	public void SelectGrab(){
		Grab = true;
	}
	public void SelectMao(){
		Mao = true;
	}
	public void SelectPitch(){
		Pitch = true;
	}
	public void SelectYaw(){
		Yaw = true;
	}
	public void SelecRoll(){
		Roll = true;
	}
	public void ChangeScene (string SceneName){
		Terminou.terminou = false;
		SceneManager.LoadScene (SceneName);
	}
}
