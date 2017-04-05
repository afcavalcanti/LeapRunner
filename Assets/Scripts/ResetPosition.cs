using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetPosition : MonoBehaviour {

	public static float cont;

    void OnTriggerEnter (Collider other){
        SceneManager.LoadScene("Level");
		cont = Timer.tempo;
    }
}
