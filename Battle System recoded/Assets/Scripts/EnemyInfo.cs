using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour {

    public string enemy_name;
    public int enemy_attack;
    public int enemy_max_health;
    public int enemy_speed;
    public string enemy_attack_name_1;
    public string enemy_attack_name_2;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
