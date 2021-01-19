using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour{

	public float speed = 0.001f;
	public float jumph = 50f;

	void Start () { print ("Start"); }

	void Update () {

		Vector3 dp = new Vector3();

		if (Input.GetKey (KeyCode.Q)) {
			dp.x -= speed;
		}

		if (Input.GetKey (KeyCode.D)) {
			dp.x += speed;	
		}
		if (Input.GetKey (KeyCode.Z)) {
			dp.y += speed;	
		}

		transform.position += dp;
	}
}