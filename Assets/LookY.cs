using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour {
 	void Update () {
		float mouseY = Input.GetAxis("Mouse Y");

		Vector3 newRotation = transform.localEulerAngles;
		newRotation.x -= mouseY;
		transform.localEulerAngles = newRotation;

		transform.localEulerAngles = new Vector3(	transform.localEulerAngles.x, 
													transform.localEulerAngles.y + mouseY, 
													transform.localEulerAngles.z
												);
	}
}
