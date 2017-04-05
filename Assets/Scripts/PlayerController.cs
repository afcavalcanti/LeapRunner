using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Leap;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	Controller LeapController;
	private float translacao;
	private float profundidade;

	// Use this for initialization
	void Start () {

		LeapController = new Controller ();
	}

	// Update is called once per frame
	void Update () {
		Frame frame = LeapController.Frame ();
		if (frame.Hands.Count > 0) {

			List<Hand> hands = frame.Hands;
			Hand hand = hands [0];

			if (Menu.Pitch == true) {
				translacao = -hand.Direction.Pitch * 4f;
			}
			if (Menu.Yaw == true) {
				translacao = -hand.Direction.Yaw * 8f;
			}
			if (Menu.Roll == true) {
				translacao = hand.Direction.Roll;
			}
			if (Menu.X == true) {
				translacao = -hand.PalmPosition.x * 0.1f; 
			} 
			if (Menu.Grab == true) {
				if (hand.GrabStrength > 0.5f) {
					translacao = -2.5f;
				} 
				if (hand.GrabStrength < 0.5f) {
					translacao = 2.5f;
				} 
			} 
			if (Menu.Mao == true) {
				if (hand.IsRight) {
					translacao = -2.5f; 
				}
				if (hand.IsLeft) {
					translacao = 2.5f; 
				}
			} 
			translacao *= Time.deltaTime;
			profundidade = 5f;
			profundidade *= Time.deltaTime;
			transform.Translate (profundidade, 0, translacao);
		}
	}
}