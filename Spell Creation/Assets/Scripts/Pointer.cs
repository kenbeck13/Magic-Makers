using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

	public LayerMask ignoreMe;
	public Ingredient currentIngredient;
	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 100, ~ignoreMe);
		if (hit.collider != null) {
			if (Input.GetMouseButtonDown (0)) {
				if (hit.collider.gameObject.tag == "Item Slot") {
					ItemSlot slotScript = hit.collider.gameObject.GetComponent<ItemSlot> ();
					if (slotScript.amount > 0 && currentIngredient == null) {
						currentIngredient = slotScript.currentIngredient;
						slotScript.amount--;
					} else {
						if (currentIngredient == slotScript.currentIngredient) {
							currentIngredient = null;
							slotScript.amount++;
						}
					}
				}
				if (hit.collider.gameObject.tag == "Cauldron Slot") {
					CauldronSlot slotScript = hit.collider.gameObject.GetComponent<CauldronSlot> ();
					if (slotScript.currentIngredient == null && currentIngredient != null) {
						slotScript.currentIngredient = currentIngredient;
						currentIngredient = null;
					} else {
						currentIngredient = slotScript.currentIngredient;
						slotScript.currentIngredient = null;
					}
				}
			}
		}
//		if (currentIngredient != null) {
//			rend.enabled = true;
//			rend.sprite = currentIngredient.itemSprite;
//		} else {
//			rend.enabled = false;
//		}

		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = mousePos;
	}

}
