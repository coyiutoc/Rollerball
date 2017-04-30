using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorLerp : MonoBehaviour {

	void Update() {

		UnityEngine.UI.Text text=GetComponent<Text>();
		if (text.CompareTag ("Cube")) {
			text.color = Color.Lerp (Color.white, new Color32 (0, 255, 55, 255), Mathf.PingPong (Time.time, 1));

		} else if (text.CompareTag ("BonusCube")) {
			text.color = Color.Lerp (Color.white, Color.yellow, Mathf.PingPong (Time.time, 1));

		}
//		else if (text.CompareTag ("MainTitle")) {
//			text.color = Color.Lerp (new Color32 (2, 240, 250, 255), new Color32 (255, 41, 41, 255), Mathf.PingPong (Time.time, 1));
//
//		} 
		else {
			text.color = Color.Lerp (Color.white, new Color32 (2, 240, 250, 255), Mathf.PingPong (Time.time, 1));
		}
		//GetComponent<Text>().color = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
		//lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
	}
}
