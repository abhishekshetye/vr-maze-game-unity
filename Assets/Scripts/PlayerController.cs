using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	private bool walking = false;
	public int speed = 0;
	private Vector3 spawnpoint;
	public Camera cam;

	// Use this for initialization
	void Start () {
		spawnpoint = transform.position;
	}


	// Update is called once per frame
	void Update () {

		Debug.Log ("walking " + walking);

		if (walking) {
			transform.position += cam.transform.forward * speed * Time.deltaTime;
		}


		if (transform.position.y < -10) {
			transform.position = spawnpoint;
		}


//		if (Input.GetButton ("Fire1")) {
//			if (walking == true)
//								walking = false;
//							else
//								walking = true;
//		}
//			
	

//		if (Input.GetButton ("Fire2")) {
//			if (walking == true)
//				walking = false;
//			else
//				walking = true;
//			
//		}


		if (Input.anyKeyDown)
		{
				if (walking == true)
					walking = false;
				else
					walking = true;
			
		}

//		Ray ray = camera.ViewportPointToRay (new Vector3 (speed, speed, 0f));
//		RaycastHit hit;
//
//		if (Physics.Raycast (ray, out hit)) {
//			if (hit.collider.name.Contains ("plane")) {
//				walking = false;
//				Debug.Log ("Hit ground");
//			} else {
//				walking = true;
//			}
//		}

//		transform.position += transform.forward * speed * Time.deltaTime;
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		Vector3 moveForward = transform.forward;
//
//		Vector3 position = transform.position;
//		position.x += moveHorizontal * speed * Time.deltaTime;
//		position.z += moveVertical * speed * Time.deltaTime;
//		transform.position = position;
	}
}