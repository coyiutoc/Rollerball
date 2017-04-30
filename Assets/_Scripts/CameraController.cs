//using UnityEngine;
//using System.Collections;
//
//public class CameraController : MonoBehaviour {
//
//	public GameObject Player;       //Public variable to store a reference to the player game object
//	public float speed;
//
//	private Vector3 offset;         //Private variable to store the offset distance between the player and camera
//
//	// Use this for initialization
//	void Start () 
//	{
//		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
//		offset = transform.position - Player.transform.position;
//	}
//
//	// LateUpdate is called after Update each frame
//	void LateUpdate () 
//	{
//		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
//		transform.position = Player.transform.position + offset;
//	}
//
//	void Update()
//	{
//		if(Input.GetKey(KeyCode.RightArrow))
//		{
//			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
//		}
//		if(Input.GetKey(KeyCode.LeftArrow))
//		{
//			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
//		}
//		if(Input.GetKey(KeyCode.DownArrow))
//		{
//			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
//		}
//		if(Input.GetKey(KeyCode.UpArrow))
//		{
//			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
//		}
//	}
//
//}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	public float speed;

	void Start ()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}
	}
}