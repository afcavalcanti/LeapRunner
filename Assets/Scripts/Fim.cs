using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fim : MonoBehaviour {

	public Text text;
	public static string m;
	public static string s;

	void Update () {
		text.text = m + ":" + s;
	}
	public void ChangeScene (string SceneName){
		SceneManager.LoadScene (SceneName);
	}
}
