using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private GameController gameController; 
	public GameObject explosion; 
	public float speed;
	public float colourChangeDelay = 0.5f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;
	bool colourChangeBonus = false;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void Update()
	{
		checkColourChange();
	}
		
	void FixedUpdate () {

		UnityEngine.Rigidbody rb = GetComponent < Rigidbody> ();

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Determines movement using input --> y axis should be ZERO (only moving up and down) 
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 

		rb.velocity = movement * speed; 
		//rb.AddForce (movement * speed);
	}
		
	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("Contact made!");

		if (other.gameObject.CompareTag ("Cube")) {
			other.gameObject.SetActive (false);
			colourChangeCollision = true;
			currentDelay = Time.time + colourChangeDelay;

			gameController.addScore ("normal"); 
		
		} else if (other.gameObject.CompareTag ("BonusCube")) {
			other.gameObject.SetActive (false);
			colourChangeBonus = true;

			currentDelay = Time.time + colourChangeDelay;

			gameController.addScore ("bonus");
		} else if (other.gameObject.CompareTag ("Enemy")) {
			//Instantiate(explosion, transform.position, transform.rotation);
			//Destroy (gameObject);
			gameController.setGameOver (); 
		} else if (other.gameObject.CompareTag ("End")) {
			Debug.Log ("Entered end square.");
			gameController.setLevelComplete ();
		}
	}
		
	void checkColourChange()
	{        
		if(colourChangeCollision || colourChangeBonus)
		{
			if (colourChangeCollision) {
				transform.GetComponent<Renderer> ().material.color = new Color32 (0, 255, 55, 255);

			}
			if (colourChangeBonus) {
				transform.GetComponent<Renderer> ().material.color = Color.yellow; 

			}
			if(Time.time > currentDelay)
			{
				transform.GetComponent<Renderer> ().material.color = new Color32(2, 240, 250, 255);
				colourChangeCollision = false;
				colourChangeBonus = false;
			}
		}
	}
		
//	void SetCountText(){
//		Score.text = "Score: " + count.ToString ();
//	}
}
