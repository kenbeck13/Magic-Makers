using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageNumber : MonoBehaviour {

	public float speed, timer;
	public Text myText;
	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		transform.position = new Vector2 (transform.position.x, transform.position.y + speed);
		timer -= Time.deltaTime;
		if (timer < 0) {
			Destroy (gameObject);
		}
	}
}
