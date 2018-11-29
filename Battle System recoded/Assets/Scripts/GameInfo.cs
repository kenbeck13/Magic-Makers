using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {

    int[] enemiesToBattle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartBattle(enemiesToBattle);
	}

    void StartBattle(int[] enemies) {
        
    }
}
