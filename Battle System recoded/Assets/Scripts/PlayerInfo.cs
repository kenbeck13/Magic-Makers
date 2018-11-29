using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    public string player_name;
    //basic stats
    public int player_max_health;
    public int player_current_health;
    public int player_max_magic;
    public int player_current_magic;
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
    //level up requirements
    public int[] level_up_requirements;
    //element skill tree unlocks
    public bool[] player_fire_unlocks;
    public bool[] player_water_unlocks;
    public bool[] player_earth_unlocks;
    public bool[] player_air_unlocks;
    public bool[] player_light_unlocks;
    public bool[] player_dark_unlocks;

	// Use this for initialization
	void Start () {
        player_current_health = player_max_health;
        player_current_magic = player_max_magic;
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetMouseButtonDown(0)){
        //    player_fire_exp++;
        //    player_water_exp++;
        //    player_earth_exp++;
        //    player_air_exp++;
        //    player_light_exp++;
        //    player_dark_exp++;
        //}

        if(player_fire_exp >= level_up_requirements[player_fire_level])
        {
            player_fire_level++;
        }
        if (player_water_exp >= level_up_requirements[player_water_level])
        {
            player_water_level++;
        }
        if (player_earth_exp >= level_up_requirements[player_earth_level])
        {
            player_earth_level++;
        }
        if (player_air_exp >= level_up_requirements[player_air_level])
        {
            player_air_level++;
        }
        if (player_light_exp >= level_up_requirements[player_light_level])
        {
            player_light_level++;
        }
        if (player_dark_exp >= level_up_requirements[player_dark_level])
        {
            player_dark_level++;
        }
	}
}
