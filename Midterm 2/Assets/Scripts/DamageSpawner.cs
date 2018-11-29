using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageSpawner : MonoBehaviour {

	public GameObject numberPrefab;
	public Color damage, healing;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}

	public void CreateNumber(int number){
		GameObject newNumber = (GameObject)Instantiate(numberPrefab, transform.position, Quaternion.identity);
        newNumber.transform.SetParent (this.transform, true);
		Text newNumberText = newNumber.GetComponent<Text> ();
		if (number >= 0) {
			newNumberText.color = damage;
		} else {
			newNumberText.color = healing;
		}
		newNumberText.text = "" + Mathf.Abs(number);
	}
}
