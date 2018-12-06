using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour {

	//name, stat1type, stat1value, stat2type, stat2value, sprite
	public Dictionary<string, Ingredient> ingredients;

	public string itemName;
	public float damageMultiplier;
	public float costMultiplier;
	public string bonusType;
	public float bonusMultiplier;
	public Sprite itemSprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
