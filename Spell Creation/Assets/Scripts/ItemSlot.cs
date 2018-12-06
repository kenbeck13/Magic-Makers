using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour {

	public Ingredient currentIngredient;
	SpriteRenderer rend;
	public int amount;
	public Text amountText;
	public Pointer pointer;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();

	}

	// Update is called once per frame
	void Update () {
		amountText.text = amount + "x";
		//rend.sprite = currentIngredient.itemSprite;


	}
		
}
