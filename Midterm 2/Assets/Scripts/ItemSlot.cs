using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour {

	public Dictionary<string, Ingredient> ingredients;
	public Sprite[] sprites;
	public IngredientList list;

	public Ingredient currentItem;
	public bool inCauldron;
	SpriteRenderer rend;

	// Use this for initialization
	void Start () {
		ingredients = new Dictionary<string, Ingredient> ();
		ingredients.Add ("Fire Crystal", list.fireCrystal);
		ingredients.Add ("Water Crystal", list.waterCrystal);
		ingredients.Add ("Earth Crystal", list.earthCrystal);
		ingredients.Add ("Air Crystal", list.airCrystal);
		ingredients.Add ("Light Crystal", list.lightCrystal);
		ingredients.Add ("Dark Crystal", list.darkCrystal);
		ingredients.Add ("Golden Leaf", list.goldenleaf);
		ingredients.Add ("Magic Fruit", list.magicFruit);
		ingredients.Add ("Slippery Slime", list.slipperySlime);
		ingredients.Add ("Energy Gem", list.dangerHorn);
		ingredients.Add ("Energy Gem", list.energyGem);
		ingredients.Add ("Gold Dust", list.goldDust);
		ingredients.Add ("Slimy Salt", list.slimySalt);
		ingredients.Add ("Sky Rock", list.skyRock);
		ingredients.Add ("Ice Essence", list.iceEssence);

	}
	
	// Update is called once per frame
	void Update () {
		if (currentItem == null) {
			rend.enabled = false;
		} else {
			rend.enabled = true;
			rend.sprite = currentItem.itemSprite;
		}
	}
}
