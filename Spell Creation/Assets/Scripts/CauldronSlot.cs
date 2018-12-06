using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronSlot : MonoBehaviour {

	public Ingredient currentIngredient;
	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentIngredient != null) {
			rend.enabled = true;
			rend.sprite = currentIngredient.itemSprite;
		} else {
			rend.enabled = false;
		}
	}
}
