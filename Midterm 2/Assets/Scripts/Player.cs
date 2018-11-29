using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Vector2 velocity;
	public float normalSpeed, sprintSpeed;
	float speed;
	Rigidbody2D rb;
	public float dontMoveTimerMax;
	float dontMoveTimer;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dontMoveTimer < 0) {
			velocity.x = Input.GetAxis ("Horizontal") * speed;
			velocity.y = Input.GetAxis ("Vertical") * speed;
		}
		rb.MovePosition(rb.position + velocity * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftShift)) {
			speed = sprintSpeed;
		} else {
			speed = normalSpeed;
		}

		dontMoveTimer -= Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Door") {
			GameObject enteredDoor = col.gameObject;
			Door enteredDoorScript = enteredDoor.GetComponent<Door> ();
			GameObject exitedDoor = enteredDoorScript.pairedDoor;
			Door exitedDoorScript = exitedDoor.GetComponent<Door> ();
			Vector3 spawnPoint = exitedDoorScript.spawnPoint;
			transform.position = exitedDoor.transform.position + spawnPoint;
			velocity.Set (0, 0);
			dontMoveTimer = dontMoveTimerMax;
		}
		if (col.gameObject.tag == "Enemy") {
			SceneManager.LoadScene ("Battle");
		}
	}

}
