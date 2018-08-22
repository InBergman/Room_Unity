using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour {

	void Start ()
	{
		
	}
	
	void Update ()
	{
		float mouseX = Input.GetAxis("Mouse X");

		Vector3 newRotation = transform.localEulerAngles;
		newRotation.y += mouseX;
		transform.localEulerAngles = newRotation;

		transform.localEulerAngles = new Vector3(	transform.localEulerAngles.x, 
													transform.localEulerAngles.y + mouseX, 
													transform.localEulerAngles.z
												);
	}
}
