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

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		fireCrystal.itemName = "Fire Crystal";
		fireCrystal.damageMultiplier = 1.5625f;
		fireCrystal.costMultiplier = 1.4f;
		fireCrystal.bonusType = "Burn";
		fireCrystal.bonusMultiplier = 0.5f;
		fireCrystal.itemSprite = sprites [0];

		waterCrystal.itemName = "Water Crystal";
		waterCrystal.damageMultiplier = 0.8f;
		waterCrystal.costMultiplier = 0.7f;
		waterCrystal.bonusType = null;
		waterCrystal.bonusMultiplier = null;
		waterCrystal.itemSprite = sprites [1];

		earthCrystal.itemName = "Earth Crystal";
		earthCrystal.damageMultiplier = 1.25f;
		earthCrystal.costMultiplier = null;
		earthCrystal.bonusType = null;
		earthCrystal.bonusMultiplier = null;
		earthCrystal.itemSprite = sprites [2];

		airCrystal.itemName = "Air Crystal";
		airCrystal.costMultiplier = "Cost";
		airCrystal.damageMultiplier = null;
		airCrystal.bonusType = null;
		airCrystal.bonusMultiplier = null;
		airCrystal.itemSprite = sprites [3];

		lightCrystal.itemName = "Light Crystal";
		lightCrystal.damageMultiplier = 1.953125f;
		lightCrystal.costMultiplier = 1.96;
		lightCrystal.bonusType = "Undead";
		lightCrystal.bonusMultiplier = 1.2f;
		lightCrystal.itemSprite = sprites [4];

		darkCrystal.itemName = "Dark Crystal";
		darkCrystal.damageMultiplier = 1.5625;
		darkCrystal.costMultiplier = 1.4;
		darkCrystal.bonusType = null;
		darkCrystal.bonusMultiplier = null;
		darkCrystal.itemSprite = sprites [5];

		goldenleaf.itemName = "Golden Leaf";
		goldenleaf.costMultiplier = 0.8f;
		goldenleaf.damageMultiplier = null;
		goldenleaf.bonusType = null;
		goldenleaf.bonusMultiplier = null;
		goldenleaf.itemSprite = sprites [6];

		magicFruit.itemName = "Magic Fruit";
		magicFruit.costMultiplier = 0.8f;
		magicFruit.damageMultiplier = 1.15f;
		magicFruit.bonusType = "No Bonuses";
		magicFruit.bonusMultiplier = null;
		magicFruit.itemSprite = sprites [7];

		slipperySlime.itemName = "Slippery Slime";
		slipperySlime.costMultiplier = 1.25f;
		slipperySlime.damageMultiplier = 1.3225f;
		slipperySlime.bonusType = "Water Cost";
		slipperySlime.bonusMultiplier = 0.8f;
		slipperySlime.itemSprite = sprites [8];

		dangerHorn.itemName = "Danger Horn";
		dangerHorn.costMultiplier = null;
		dangerHorn.damageMultiplier = 1.15f;
		dangerHorn.bonusType = null;
		dangerHorn.bonusMultiplier = null;
		dangerHorn.itemSprite = sprites [9];

		energyGem.itemName = "Energy Gem";
		energyGem.costMultiplier = 0.8f;
		energyGem.damageMultiplier = null;
		energyGem.bonusType = "Lightning Crystal Cost";
		energyGem.bonusMultiplier = 0.8f;
		energyGem.itemSprite = sprites [10];

		goldDust.itemName = "Gold Dust";
		goldDust.costMultiplier = 0.64f;
		goldDust.damageMultiplier = null;
		goldDust.bonusType = null;
		goldDust.bonusMultiplier = null;
		goldDust.itemSprite = sprites [11];

		slimySalt.itemName = "Slimy Salt";
		slimySalt.costMultiplier = 0.8f;
		slimySalt.damageMultiplier = null;
		slimySalt.bonusType = "Water Life Cost";
		slimySalt.bonusMultiplier = 0.8f;
		slimySalt.itemSprite = sprites [12];

		skyRock.itemName = "Sky Rock";
		skyRock.costMultiplier = null;
		skyRock.damageMultiplier = null;
		skyRock.bonusType = "Solar Lunar Cosmic Air Rainbow Divine Storm Damage";
		skyRock.bonusMultiplier = 1.3225f;
		skyRock.itemSprite = sprites [13];

		iceEssence.itemName = "Sky Rock";
		iceEssence.costMultiplier = null;
		iceEssence.damageMultiplier = null;
		iceEssence.bonusType = "Remove Burn Ice Damage";
		iceEssence.bonusMultiplier = 1.520875f;
		iceEssence.itemSprite = sprites [14];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
