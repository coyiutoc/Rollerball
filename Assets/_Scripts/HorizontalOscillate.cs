﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalOscillate : MonoBehaviour {

	public float speed = 3;
	//direction in which the object moves. 1 is for right and -1 for left
	float dir = 1;

	void Update(){
		//move the object at a rate of 1*speed unit/s along the x-axis
		transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * dir * speed);
	}

	//check if the object hits the other two cubes
	void OnTriggerEnter(Collider coll){

		if(coll.gameObject.tag=="Wall" || coll.gameObject.tag=="Enemy"){
			//reverse the current direction 
			dir *= -1;
		}
	}
}
