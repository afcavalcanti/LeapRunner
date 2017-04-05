using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminou : MonoBehaviour {

	public static bool terminou=false;

	void OnTriggerEnter(Collider Other) {
		terminou = true;
		SceneManager.LoadScene ("Final");
	}
}
