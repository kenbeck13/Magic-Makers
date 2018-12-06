using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientList : MonoBehaviour {

	public Ingredient fireCrystal;
	public Ingredient waterCrystal;
	public Ingredient earthCrystal;
	public Ingredient airCrystal;
	public Ingredient lightCrystal;
	public Ingredient darkCrystal;
	public Ingredient goldenleaf;
	public Ingredient magicFruit;
	public Ingredient slipperySlime;
	public Ingredient dangerHorn;
	public Ingredient energyGem;
	public Ingredient goldDust;
	public Ingredient slimySalt;
	public Ingredient skyRock;
	public Ingredient iceEssence;

	//public Sprite[] sprites;

	// Use this for initialization
	void Awake () {
		fireCrystal.itemName = "Fire Crystal";
		fireCrystal.damageMultiplier = 1.5625f;
		fireCrystal.mpCostMultiplier = 1.4f;
		fireCrystal.specialBonus = "Burn";
		fireCrystal.specialBonusValue = 0.5f;
		//fireCrystal.itemSprite = sprites [0];

		waterCrystal.itemName = "Water Crystal";
		waterCrystal.damageMultiplier = 0.8f;
		waterCrystal.mpCostMultiplier = 0.7f;
		waterCrystal.specialBonus = null;
		waterCrystal.specialBonusValue = 0.0f;
		//waterCrystal.itemSprite = sprites [1];

		earthCrystal.itemName = "Earth Crystal";
		earthCrystal.damageMultiplier = 1.25f;
		earthCrystal.mpCostMultiplier = 1.0f;
		earthCrystal.specialBonus = null;
		earthCrystal.specialBonusValue = 0.0f;
		//earthCrystal.itemSprite = sprites [2];

		airCrystal.itemName = "Air Crystal";
		airCrystal.mpCostMultiplier = 0.7f;
		airCrystal.damageMultiplier = 1.0f;
		airCrystal.specialBonus = null;
		airCrystal.specialBonusValue = 0.0f;
		//airCrystal.itemSprite = sprites [3];

		lightCrystal.itemName = "Light Crystal";
		lightCrystal.damageMultiplier = 1.953125f;
		lightCrystal.mpCostMultiplier = 1.96f;
		lightCrystal.specialBonus = "Undead";
		lightCrystal.specialBonusValue = 1.2f;
		//lightCrystal.itemSprite = sprites [4];

		darkCrystal.itemName = "Dark Crystal";
		darkCrystal.damageMultiplier = 1.5625f;
		darkCrystal.mpCostMultiplier = 1.4f;
		darkCrystal.specialBonus = null;
		darkCrystal.specialBonusValue = 0.0f;
		//darkCrystal.itemSprite = sprites [5];

		goldenleaf.itemName = "Golden Leaf";
		goldenleaf.mpCostMultiplier = 0.8f;
		goldenleaf.damageMultiplier = 1.0f;
		goldenleaf.specialBonus = null;
		goldenleaf.specialBonusValue = 0.0f;
		//goldenleaf.itemSprite = sprites [6];

		magicFruit.itemName = "Magic Fruit";
		magicFruit.mpCostMultiplier = 0.8f;
		magicFruit.damageMultiplier = 1.15f;
		magicFruit.specialBonus = "No Bonuses";
		magicFruit.specialBonusValue = 0.0f;
		//magicFruit.itemSprite = sprites [7];

		slipperySlime.itemName = "Slippery Slime";
		slipperySlime.mpCostMultiplier = 1.25f;
		slipperySlime.damageMultiplier = 1.3225f;
		slipperySlime.specialBonus = "Water Cost";
		slipperySlime.specialBonusValue = 0.8f;
		//slipperySlime.itemSprite = sprites [8];

		dangerHorn.itemName = "Danger Horn";
		dangerHorn.mpCostMultiplier = 1.0f;
		dangerHorn.damageMultiplier = 1.15f;
		dangerHorn.specialBonus = null;
		dangerHorn.specialBonusValue = 0.0f;
		//dangerHorn.itemSprite = sprites [9];

		energyGem.itemName = "Energy Gem";
		energyGem.mpCostMultiplier = 0.8f;
		energyGem.damageMultiplier = 1.0f;
		energyGem.specialBonus = "Lightning Crystal Cost";
		energyGem.specialBonusValue = 0.8f;
		//energyGem.itemSprite = sprites [10];

		goldDust.itemName = "Gold Dust";
		goldDust.mpCostMultiplier = 0.64f;
		goldDust.damageMultiplier = 1.0f;
		goldDust.specialBonus = null;
		goldDust.specialBonusValue = 0.0f;
		//goldDust.itemSprite = sprites [11];

		slimySalt.itemName = "Slimy Salt";
		slimySalt.mpCostMultiplier = 0.8f;
		slimySalt.damageMultiplier = 1.0f;
		slimySalt.specialBonus = "Water Life Cost";
		slimySalt.specialBonusValue = 0.8f;
		//slimySalt.itemSprite = sprites [12];

		skyRock.itemName = "Sky Rock";
		skyRock.mpCostMultiplier = 1.0f;
		skyRock.damageMultiplier = 1.0f;
		skyRock.specialBonus = "Solar Lunar Cosmic Air Rainbow Divine Storm Damage";
		skyRock.specialBonusValue = 1.3225f;
		//skyRock.itemSprite = sprites [13];

		iceEssence.itemName = "Ice Essence";
		iceEssence.mpCostMultiplier = 1.0f;
		iceEssence.damageMultiplier = 1.0f;
		iceEssence.specialBonus = "Remove Burn Ice Damage Freeze Chance";
		iceEssence.specialBonusValue = 1.520875f;
		//iceEssence.itemSprite = sprites [14];
	}

	// Update is called once per frame
	void Update () {

	}
}
