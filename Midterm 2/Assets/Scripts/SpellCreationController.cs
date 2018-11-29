using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCreationController : MonoBehaviour {

    public string spell_name;
    public int spell_damage;
    public int spell_healing;
    public int spell_cost;
    public string spell_damage_target;
    public string spell_healing_target;
    public string spell_special;
    public bool isDesperation;

    public Spell player1Spell0;
    public Spell player1Spell1;
    public Spell player1Spell2;
    public Spell player1Spell3;
    public Spell player1Spell4;
    public Spell player2Spell0;
    public Spell player2Spell1;
    public Spell player2Spell2;
    public Spell player2Spell3;
    public Spell player2Spell4;

    public SpellInfo spellInfo;

	// Use this for initialization
	void Start () {
        player1Spell0 = new Spell();
        player1Spell1 = new Spell();
        player1Spell2 = new Spell();
        player1Spell3 = new Spell();
        player1Spell4 = new Spell();
        player2Spell0 = new Spell();
        player2Spell1 = new Spell();
        player2Spell2 = new Spell();
        player2Spell3 = new Spell();
        player2Spell4 = new Spell();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FinishCrafting(Spell spellToFinish){
        spellToFinish.spell_name = spell_name;
        spellToFinish.spell_damage = spell_damage;
        spellToFinish.spell_healing = spell_healing;
        spellToFinish.spell_cost = spell_cost;
        spellToFinish.spell_damage_target = spell_damage_target;
        spellToFinish.spell_healing_target = spell_healing_target;
        spellToFinish.spell_special = spell_special;
        spellToFinish.isDesperation = isDesperation;
    }
}
