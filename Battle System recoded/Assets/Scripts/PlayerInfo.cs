using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    public string player_name;
    //basic stats
    public int player_max_health;
    public int player_current_health;
    public int player_max_magic;
    public int player_magic;
    public int player_defense;
    public int player_speed;
    //spell info
    public string[] player_spell_name;
    public string[] player_spell_element;
    public int[] player_spell_attack;
    public int[] player_spell_magic_cost;
    public string[] player_spell_special;
    //element exp
    public int player_fire_exp;
    public int player_water_exp;
    public int player_earth_exp;
    public int player_air_exp;
    public int player_light_exp;
    public int player_dark_exp;
    //element level
    public int player_fire_level;
    public int player_water_level;
    public int player_earth_level;
    public int player_air_level;
    public int player_light_level;
    public int player_dark_level;
    //element skill tree unlocks
    public bool[] player_fire_unlocks;
    public bool[] player_water_unlocks;
    public bool[] player_earth_unlocks;
    public bool[] player_air_unlocks;
    public bool[] player_light_unlocks;
    public bool[] player_dark_unlocks;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
