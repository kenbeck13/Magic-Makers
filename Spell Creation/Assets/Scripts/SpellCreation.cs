using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpellCreation : MonoBehaviour {

	public GameObject cauldronFire;
	string firstElement;
	string secondElement;
	//Burn, Freeze, etc.
	string status;
	//Healing, Undead Damage, etc.
	string special;
	//Reduced MP Cost/ Increased Damage for certain elements
	string bonus;
	Spell finalSpell;
	int fireElement, waterElement, earthElement, airElement, lightElement, darkElement;
	float damage, cost, bonusDamage, bonusCost;
	public CauldronSlot[] slots;
	Ingredient[] chosenIngredients;
	bool disable, alwaysDisabled;
	public Button spellCreationButton;

	// Use this for initialization
	void Start () {
		chosenIngredients = new Ingredient[]{null, null, null, null, null, null, null, null, null, null};
		spellCreationButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (disable) {
			spellCreationButton.interactable = false;
		} else if(!alwaysDisabled){
			spellCreationButton.interactable = true;
		}
		if (Input.GetMouseButtonDown (0)) {
			CheckCauldronContents ();
		}
	}

	void CheckCauldronContents(){
		firstElement = null;
		secondElement = null;
		disable = false;
		for (int i = 0; i < slots.Length; i++) {
			chosenIngredients [i] = slots [i].currentIngredient;
			if (chosenIngredients [i] != null) {
				if (chosenIngredients [i].itemName == "Fire Crystal") {
					fireElement++;
					if (firstElement == null) {
						firstElement = "Fire";
					} else if (firstElement != "Fire" && secondElement == null) {
						secondElement = "Fire";
					} else {
						disable = true;
					}
				} else if (chosenIngredients [i].itemName == "Water Crystal") {
					waterElement++;
					if (firstElement == null) {
						firstElement = "Water";
					} else if (firstElement != "Water" && secondElement == null) {
						secondElement = "Water";
					} else {
						disable = true;
					}
				} else if (chosenIngredients [i].itemName == "Earth Crystal") {
					earthElement++;
					if (firstElement == null) {
						firstElement = "Earth";
					} else if (firstElement != "Earth" && secondElement == null) {
						secondElement = "Earth";
					} else {
						disable = true;
					}
				} else if (chosenIngredients [i].itemName == "Air Crystal") {
					airElement++;
					if (firstElement == null) {
						firstElement = "Air";
					} else if (firstElement != "Air" && secondElement == null) {
						secondElement = "Air";
					} else {
						disable = true;
					}
				} else if (chosenIngredients [i].itemName == "Light Crystal") {
					lightElement++;
					if (firstElement == null) {
						firstElement = "Light";
					} else if (firstElement != "Light" && secondElement == null) {
						secondElement = "Light";
					} else {
						disable = true;
					}
				} else if (chosenIngredients [i].itemName == "Dark Crystal") {
					darkElement++;
					if (firstElement == null) {
						firstElement = "Dark";
					} else if (firstElement != "Dark" && secondElement == null) {
						secondElement = "Dark";
					} else {
						disable = true;
					}
				}
			}
		}
		if (firstElement == null && secondElement == null) {
			disable = true;
		}
	}

	public void CreateSpell(){
		CheckCauldronContents ();
		FinalElement ();
		SpellSpecials ();
		FinalDamageAndCost ();
		alwaysDisabled = true;
	}

	void FinalElement(){
		if (firstElement == "Fire" && secondElement == null) {
			finalSpell.spell_element = "Fire";
		} else if (firstElement == "Fire" && secondElement == "Water") {
			finalSpell.spell_element = "Steam";
		} else if (firstElement == "Fire" && secondElement == "Earth") {
			finalSpell.spell_element = "Magma";
		} else if (firstElement == "Fire" && secondElement == "Air") {
			finalSpell.spell_element = "Solar";
		} else if (firstElement == "Fire" && secondElement == "Light") {
			finalSpell.spell_element = "Lightning";
		} else if (firstElement == "Fire" && secondElement == "Dark") {
			finalSpell.spell_element = "Hellfire";
		} else if (firstElement == "Water" && secondElement == null) {
			finalSpell.spell_element = "Water";
		} else if (firstElement == "Water" && secondElement == "Fire") {
			finalSpell.spell_element = "Steam";
		} else if (firstElement == "Water" && secondElement == "Earth") {
			finalSpell.spell_element = "Life";
		} else if (firstElement == "Water" && secondElement == "Air") {
			finalSpell.spell_element = "Storm";
		} else if (firstElement == "Water" && secondElement == "Light") {
			finalSpell.spell_element = "Rainbow";
		} else if (firstElement == "Water" && secondElement == "Dark") {
			finalSpell.spell_element = "Ice";
		} else if (firstElement == "Earth" && secondElement == null) {
			finalSpell.spell_element = "Earth";
		} else if (firstElement == "Earth" && secondElement == "Fire") {
			finalSpell.spell_element = "Magma";
		} else if (firstElement == "Earth" && secondElement == "Water") {
			finalSpell.spell_element = "Life";
		} else if (firstElement == "Earth" && secondElement == "Air") {
			finalSpell.spell_element = "Sand";
		} else if (firstElement == "Earth" && secondElement == "Light") {
			finalSpell.spell_element = "Crystal";
		} else if (firstElement == "Earth" && secondElement == "Dark") {
			finalSpell.spell_element = "Death";
		} else if (firstElement == "Air" && secondElement == null) {
			finalSpell.spell_element = "Air";
		} else if (firstElement == "Air" && secondElement == "Fire") {
			finalSpell.spell_element = "Solar";
		} else if (firstElement == "Air" && secondElement == "Water") {
			finalSpell.spell_element = "Storm";
		} else if (firstElement == "Air" && secondElement == "Earth") {
			finalSpell.spell_element = "Sand";
		} else if (firstElement == "Air" && secondElement == "Light") {
			finalSpell.spell_element = "Cosmic";
		} else if (firstElement == "Air" && secondElement == "Dark") {
			finalSpell.spell_element = "Lunar";
		} else if (firstElement == "Light" && secondElement == null) {
			finalSpell.spell_element = "Light";
		} else if (firstElement == "Light" && secondElement == "Fire") {
			finalSpell.spell_element = "Light";
		} else if (firstElement == "Light" && secondElement == "Water") {
			finalSpell.spell_element = "Rainbow";
		} else if (firstElement == "Light" && secondElement == "Earth") {
			finalSpell.spell_element = "Crystal";
		} else if (firstElement == "Light" && secondElement == "Air") {
			finalSpell.spell_element = "Cosmic";
		} else if (firstElement == "Light" && secondElement == "Dark") {
			finalSpell.spell_element = "Divine";
		} else if (firstElement == "Dark" && secondElement == null) {
			finalSpell.spell_element = "Dark";
		} else if (firstElement == "Dark" && secondElement == "Fire") {
			finalSpell.spell_element = "Hellfire";
		} else if (firstElement == "Dark" && secondElement == "Water") {
			finalSpell.spell_element = "Ice";
		} else if (firstElement == "Dark" && secondElement == "Earth") {
			finalSpell.spell_element = "Death";
		} else if (firstElement == "Dark" && secondElement == "Air") {
			finalSpell.spell_element = "Lunar";
		} else if (firstElement == "Dark" && secondElement == "Light") {
			finalSpell.spell_element = "Divine";
		} 
	}

	void FinalDamageAndCost(){
		damage = 2.0f;
		cost = 2.0f;
		for (int i = 0; i < slots.Length; i++) {
			chosenIngredients [i] = slots [i].currentIngredient;
			damage *= chosenIngredients [i].damageMultiplier;
			cost *= chosenIngredients [i].mpCostMultiplier;
		}
		finalSpell.spell_damage = (int)(10.0 + damage * bonusDamage);
		finalSpell.spell_cost = (int)(8.0 + cost * bonusCost);
	}

	void SpellSpecials(){
		bonusDamage = 1.0f;
		bonusCost = 1.0f;
		for (int i = 0; i < slots.Length; i++) {
			chosenIngredients [i] = slots [i].currentIngredient;
			if (chosenIngredients [i].specialBonus == "Burn") {
				finalSpell.spell_status = "Burn";
				finalSpell.spell_status_chance = chosenIngredients [i].specialBonusValue;
			} else if (chosenIngredients [i].specialBonus == "Freeze") {
				finalSpell.spell_status = "Freeze";
				finalSpell.spell_status_chance = chosenIngredients [i].specialBonusValue;
			} else if (chosenIngredients [i].specialBonus == "Undead") {
				finalSpell.spell_special = "Undead";
				finalSpell.spell_special_chance = chosenIngredients [i].specialBonusValue;
			} else if (chosenIngredients [i].specialBonus == "Healing") {
				finalSpell.spell_special = "Healing";
				finalSpell.spell_special_chance = chosenIngredients [i].specialBonusValue;
			} else if (chosenIngredients [i].specialBonus == "No Bonuses") {
				finalSpell.spell_special = "None";
				finalSpell.spell_special_chance = chosenIngredients [i].specialBonusValue;
				finalSpell.spell_status = "None";
				finalSpell.spell_status_chance = chosenIngredients [i].specialBonusValue;
			} else if (chosenIngredients [i].specialBonus == "Water Cost") {
				if (firstElement == "Water" || secondElement == "Water") {
					bonusCost *= chosenIngredients [i].specialBonusValue;
				}
			} else if (chosenIngredients [i].specialBonus == "Lightning Crystal Cost") {
				if (finalSpell.spell_element == "Lightning" || finalSpell.spell_element == "Crystal") {
					bonusCost *= chosenIngredients [i].specialBonusValue;
				}
			} else if (chosenIngredients [i].specialBonus == "Water Life Cost") {
				if (finalSpell.spell_element == "Water" || finalSpell.spell_element == "Life") {
					bonusCost *= chosenIngredients [i].specialBonusValue;
				}
			} else if (chosenIngredients [i].specialBonus == "Solar Lunar Cosmic Air Rainbow Divine Storm Damage") {
				if (finalSpell.spell_element == "Solar" || finalSpell.spell_element == "Lunar" || finalSpell.spell_element == "Air" || finalSpell.spell_element == "Cosmic" || finalSpell.spell_element == "Rainbow" || finalSpell.spell_element == "Divine" || finalSpell.spell_element == "Storm") {
					bonusDamage *= chosenIngredients [i].specialBonusValue;
				}
			} else if (chosenIngredients [i].specialBonus == "Remove Burn Ice Damage Freeze Chance") {
				if (finalSpell.spell_element == "Ice") {
					bonusDamage *= chosenIngredients [i].specialBonusValue;
					finalSpell.spell_status_chance *= 1.25f;
					finalSpell.spell_special = "BurnHeal";
				}
			}

		}
	}

	void DisplayFinalResults(){
		Debug.Log (finalSpell.spell_element);
		Debug.Log ("Damage: " + finalSpell.spell_damage);
		Debug.Log ("MP Cost: " + finalSpell.spell_cost);
		Debug.Log ("Status: " + finalSpell.spell_status);
		Debug.Log ("Chance: " + finalSpell.spell_status_chance);
		Debug.Log ("Special: " + finalSpell.spell_special);
		Debug.Log ("Chance: " + finalSpell.spell_special_chance);
	}

	public void ReloadScene(){
		SceneManager.LoadScene ("SpellCreation");
	}
}
