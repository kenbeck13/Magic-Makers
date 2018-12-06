using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

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
    public GameObject spellInfoObject;
    SpellInfo spellInfo;

	public GameObject chooseSpellP1, chooseSpellP2, chooseTargetP1, chooseTargetP2,
    news, nextButton, enemy1, enemy2, enemy3, player1, player2, slider1, slider2,
    slider3, p1Enemy1Object, p1Enemy2Object, p1Enemy3Object, p1EnemyAllObject,
    p2Enemy1Object, p2Enemy2Object, p2Enemy3Object, p2EnemyAllObject, p1Desperation,
    p2Desperation, e1Freeze, e1Burn, e2Freeze, e2Burn, e3Freeze, e3Burn;

	public Text newsText1, newsText2, newsText3, whoText, elementText, damageText,
    mpText, bonusText, player1HPText, player2HPText, player1MPText, player2MPText,
    finalText, targetText, desperationText, p1SpellName1, p1SpellName2, p1SpellName3, p1SpellName4, p2SpellName1, p2SpellName2, p2SpellName3, p2SpellName4;

    public Button p1spell1, p1spell2, p1spell3, p2spell1, p2spell2, p2spell3,
    p1EnemyButton1, p1EnemyButton2, p1EnemyButton3, p2EnemyButton1, p2EnemyButton2, p2EnemyButton3;

    public Slider e1Slider, e2Slider, e3Slider;
    int player1HP, player2HP, player1MP, player2MP, enemy1HP, enemy2HP, enemy3HP;
	public int player1MaxHP, player2MaxHP, player1MaxMP, player2MaxMP, enemy1MaxHP, enemy2MaxHP, enemy3MaxHP;
	public int p1SpellCost1, p1SpellCost2, p1SpellCost3, p2SpellCost1, p2SpellCost2, p2SpellCost3,
    p1SpellDamage1, p1SpellDamage2, p1SpellDamage3, p1SpellDamage4, p2SpellDamage1, p2SpellDamage2, p2SpellDamage3, p2SpellDamage4;

	int spellDamage1, mpCost1, spellDamage2, mpCost2, p1Target, p2Target,
    e1Target, e2Target, e3Target, e1Damage, e2Damage, e3Damage, p1Tired, p2Tired;

	string phase, p1SpellTarget, p2SpellTarget, spellSpecial1, spellSpecial2,
    enemy1Status, enemy2Status, enemy3Status;

	public string enemyType1, enemyType2, enemyType3;
	bool attacked, p1Dead, p2Dead, e1Dead, e2Dead, e3Dead, e1Thawed, e2Thawed, e3Thawed,
    victory, loss, success1_1, success2_1, success1_2, success2_2, success1_3, success2_3, desperationUsed1, desperationUsed2;

	float specialChance1, specialChance2, healingPercent1, healingPercent2;
	public DamageSpawner e1DamageText, e2DamageText, e3DamageText, p1DamageText, p2DamageText;

	// Use this for initialization
	void Start () {
        spellInfoObject = GameObject.Find("Spell Info");
        spellInfo = spellInfoObject.GetComponent<SpellInfo>();
		player1Spell0 = spellInfo.player1Spell0;
		player1Spell1 = spellInfo.player1Spell1;
		player1Spell2 = spellInfo.player1Spell2;
		player1Spell3 = spellInfo.player1Spell3;
		player1Spell4 = spellInfo.player1Spell4;

		player2Spell0 = spellInfo.player2Spell0;
		player2Spell1 = spellInfo.player2Spell1;
		player2Spell2 = spellInfo.player2Spell2;
		player2Spell3 = spellInfo.player2Spell3;
		player2Spell4 = spellInfo.player2Spell4;

		elementText.text = (" ");
		damageText.text = (" ");
		mpText.text = (" ");
		bonusText.text = (" ");
		targetText.text = (" ");
		finalText.text = (" ");
        desperationText.text = " ";
		player1HP = player1MaxHP;
		player2HP = player2MaxHP;
		player1MP = player1MaxMP;
		player2MP = player2MaxMP;
		enemy1HP = enemy1MaxHP;
		enemy2HP = enemy2MaxHP;
		enemy3HP = enemy3MaxHP;
		phase = "BeforeChoosing";
		enemy1Status = "None";
		enemy2Status = "None";
		enemy3Status = "None";
		newsText1.text = (" ");
		newsText2.text = (" ");
        chooseSpellP1.SetActive(true);
        e1Slider.maxValue = enemy1MaxHP;
        e2Slider.maxValue = enemy2MaxHP;
        e3Slider.maxValue = enemy3MaxHP;
        e1Slider.value = enemy1HP;
        e2Slider.value = enemy2HP;
        e3Slider.value = enemy3HP;

		p1SpellCost1 = player1Spell1.spell_cost;
		p1SpellDamage1 = player1Spell1.spell_damage;
		p1SpellName1.text = (player1Spell1.spell_name);


		p1SpellCost2 = player1Spell2.spell_cost;
		p1SpellDamage2 = player1Spell2.spell_damage;
		p1SpellName2.text = (player1Spell2.spell_name);

		p1SpellCost3 = player1Spell3.spell_cost;
		p1SpellDamage3 = player1Spell3.spell_damage;
		p1SpellName3.text = (player1Spell3.spell_name);

		p1SpellDamage4 = player1Spell4.spell_damage;
		p1SpellName4.text = (player1Spell4.spell_name);

		p2SpellCost1 = player2Spell1.spell_cost;
		p2SpellDamage1 = player2Spell1.spell_damage;
		p2SpellName1.text = (player2Spell1.spell_name);

		p2SpellCost2 = player2Spell2.spell_cost;
		p2SpellDamage2 = player2Spell2.spell_damage;
		p2SpellName2.text = (player2Spell2.spell_name);

		p2SpellCost3 = player2Spell3.spell_cost;
		p2SpellDamage3 = player2Spell3.spell_damage;
		p2SpellName3.text = (player2Spell3.spell_name);

		p2SpellDamage4 = player2Spell4.spell_damage;
		p2SpellName1.text = (player2Spell3.spell_name);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Current Phase: " + phase);
        e1Slider.value = enemy1HP;
        e2Slider.value = enemy2HP;
        e3Slider.value = enemy3HP;
		if (enemy1Status == "Burned") {
			e1Burn.SetActive (true);
			e1Freeze.SetActive (false);
		} else if (enemy1Status == "Frozen") {
			e1Freeze.SetActive (true);
			e1Burn.SetActive (false);
		} else {
			e1Burn.SetActive (false);
			e1Freeze.SetActive (false);
		}
		if (enemy2Status == "Burned") {
			e2Burn.SetActive (true);
			e2Freeze.SetActive (false);
		} else if (enemy2Status == "Frozen") {
			e2Freeze.SetActive (true);
			e2Burn.SetActive (false);
		} else {
			e2Burn.SetActive (false);
			e2Freeze.SetActive (false);
		}
		if (enemy3Status == "Burned") {
			e3Burn.SetActive (true);
			e3Freeze.SetActive (false);
		} else if (enemy3Status == "Frozen") {
			e3Freeze.SetActive (true);
			e3Burn.SetActive (false);
		} else {
			e3Burn.SetActive (false);
			e3Freeze.SetActive (false);
		}
		if (e1Dead) {
			enemy1Status = "None";
		}
		if (e2Dead) {
			enemy2Status = "None";
		}
		if (e3Dead) {
			enemy3Status = "None";
		}
		if (player1HP < 0) {
			player1HP = 0;
		}
		if (player1MP < 0) {
			player1MP = 0;
		}
		if (player2HP < 0) {
			player2HP = 0;
		}
		if (player2MP < 0) {
			player2MP = 0;
		}
		if (player1HP > player1MaxHP) {
			player1HP = player1MaxHP;
		}
		if (player1MP > player1MaxMP) {
			player1MP = player1MaxMP;
		}
		if (player2HP > player2MaxHP) {
			player2HP = player2MaxHP;
		}
		if (player2MP > player2MaxMP) {
			player2MP = player2MaxMP;
		}
		player1HPText.text = (player1HP + "/" + player1MaxHP + " HP");
        player2HPText.text = (player2HP + "/" + player2MaxHP + " HP");
        player1MPText.text = (player1MP + "/" + player1MaxMP + " MP");
        player2MPText.text = (player2MP + "/" + player2MaxMP + " MP");

		if (phase == "BeforeChoosing") {
			if (player1MP < p1SpellCost1) {
				p1spell1.interactable = (false);
			} else {
				p1spell1.interactable = (true);
			}
			if (player1MP < p1SpellCost2) {
				p1spell2.interactable = (false);
			} else {
				p1spell2.interactable = (true);
			}
			if (player1MP < p1SpellCost3) {
				p1spell3.interactable = (false);
			} else {
				p1spell3.interactable = (true);
			}
			if (player1HP <= player1MaxHP / 4 && player1MP >= 1 && !desperationUsed1) {
				p1Desperation.SetActive (true);
			} else {
				p1Desperation.SetActive (false);
			}
			if (player2MP < p2SpellCost1) {
				p2spell1.interactable = (false);
			} else {
				p2spell1.interactable = (true);
			}
			if (player2MP < p2SpellCost2) {
				p2spell2.interactable = (false);
			} else {
				p2spell2.interactable = (true);
			}
			if (player2MP < p2SpellCost3) {
				p2spell3.interactable = (false);
			} else {
				p2spell3.interactable = (true);
			}
			if (player2HP <= player2MaxHP / 4 && player2MP >= 1 && !desperationUsed2) {
				p2Desperation.SetActive (true);
			} else {
				p2Desperation.SetActive (false);
			}
			if (e1Dead) {
				p1EnemyButton1.interactable = (false);
				p2EnemyButton1.interactable = (false);
			} else {
				p1EnemyButton1.interactable = (true);
				p2EnemyButton1.interactable = (true);
			}
			if (e2Dead) {
				p1EnemyButton2.interactable = (false);
				p2EnemyButton2.interactable = (false);
			} else {
				p1EnemyButton2.interactable = (true);
				p2EnemyButton2.interactable = (true);
			}
			if (e3Dead) {
				p1EnemyButton3.interactable = (false);
				p2EnemyButton3.interactable = (false);
			} else {
				p1EnemyButton3.interactable = (true);
				p2EnemyButton3.interactable = (true);
			}
			p1SpellTarget = null;
			p2SpellTarget = null;
			p1Tired--;
			p2Tired--;
			e1Thawed = false;
			e2Thawed = false;
			e3Thawed = false;
			ChangePhase ();
		} else if (phase == "Player1ChooseSpell") {
			whoText.text = ("Player 1: " + player1HP + "/" + player1MaxHP + " HP  " + player1MP + "/" + player1MaxMP + " MP");
			chooseSpellP1.SetActive (true);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (false);
			news.SetActive (false);
		} else if (phase == "Player1ChooseTarget") {
			whoText.text = ("Player 1: " + player1HP + "/" + player1MaxHP + " HP  " + player1MP + "/" + player1MaxMP + " MP");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (true);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (false);
			news.SetActive (false);
			if (p1SpellTarget == "All") {
				p1Enemy1Object.SetActive (false);
				p1Enemy2Object.SetActive (false);
				p1Enemy3Object.SetActive (false);
				p1EnemyAllObject.SetActive (true);
			} else {
				p1Enemy1Object.SetActive (true);
				p1Enemy2Object.SetActive (true);
				p1Enemy3Object.SetActive (true);
				p1EnemyAllObject.SetActive (false);
			}
		} else if (phase == "Player2ChooseSpell") {
			whoText.text = ("Player 2: " + player2HP + "/" + player2MaxHP + " HP  " + player2MP + "/" + player2MaxMP + " MP");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (true);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (false);
			news.SetActive (false);
		} else if (phase == "Player2ChooseTarget") {
			whoText.text = ("Player 2: " + player2HP + "/" + player2MaxHP + " HP  " + player2MP + "/" + player2MaxMP + " MP");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (true);
			nextButton.SetActive (false);
			news.SetActive (false);
			if (p2SpellTarget == "All") {
				p2Enemy1Object.SetActive (false);
				p2Enemy2Object.SetActive (false);
				p2Enemy3Object.SetActive (false);
				p2EnemyAllObject.SetActive (true);
			} else {
				p2Enemy1Object.SetActive (true);
				p2Enemy2Object.SetActive (true);
				p2Enemy3Object.SetActive (true);
				p2EnemyAllObject.SetActive (false);
			}
		} else if (phase == "BeforeAttacking") {
			if (!e1Dead) {
				e1Target = Random.Range (1, 3);
				e1Damage = Random.Range (10, 21);
				if (p1Dead) {
					e1Target = 2;
				}
				if (p2Dead) {
					e1Target = 1;
				}
			}
			if (!e2Dead) {
				e2Target = Random.Range (1, 3);
				e2Damage = Random.Range (20, 26);
				if (p1Dead) {
					e1Target = 2;
				}
				if (p2Dead) {
					e1Target = 1;
				}
			}
			if (!e3Dead) {
				e3Target = Random.Range (1, 3);
				e3Damage = Random.Range (5, 31);
				if (p1Dead) {
					e1Target = 2;
				}
				if (p2Dead) {
					e1Target = 1;
				}
			}
			if (!attacked) {
				float chance = Random.Range (0f, 1f);
				Debug.Log (chance);
				if (chance <= specialChance1) {
					success1_1 = true;
					Debug.Log ("Special 1 Success");
				} else {
					success1_1 = false;
					Debug.Log ("Special 1 Fail");
				}
				if (p1SpellTarget == "All") {
					chance = Random.Range (0f, 1f);
					Debug.Log (chance);
					if (chance <= specialChance1) {
						success1_2 = true;
						Debug.Log ("Special 1-2 Success");
					} else {
						success1_2 = false;
						Debug.Log ("Special 1-2 Fail");
					}
					chance = Random.Range (0f, 1f);
					Debug.Log (chance);
					if (chance <= specialChance1) {
						success1_3 = true;
						Debug.Log ("Special 1-3 Success");
					} else {
						success1_3 = false;
						Debug.Log ("Special 1-3 Fail");
					}
				}
				chance = Random.Range (0f, 1f);
				Debug.Log (chance);
				if (chance <= specialChance2) {
					success2_1 = true;
					Debug.Log ("Special 2 Success");
				} else {
					success2_1 = false;
					Debug.Log ("Special 2 Fail");
				}
				if (p2SpellTarget == "All") {
					chance = Random.Range (0f, 1f);
					Debug.Log (chance);
					if (chance <= specialChance1) {
						success2_2 = true;
						Debug.Log ("Special 2-2 Success");
					} else {
						success2_2 = false;
						Debug.Log ("Special 2-2 Fail");
					}
					chance = Random.Range (0f, 1f);
					Debug.Log (chance);
					if (chance <= specialChance1) {
						success2_3 = true;
						Debug.Log ("Special 2-3 Success");
					} else {
						success2_3 = false;
						Debug.Log ("Special 2-3 Fail");
					}
				}
				attacked = true;
			}
			ChangePhase ();
		} else if (phase == "Player1Attacks" && p1Tired == 1) {
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			newsText1.text = "Player 1 is tired from using their Desperation Spell!";
		} else if (phase == "Player1Attacks" && p1Tired != 1) {
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			if (p1Target == 1 && e1Dead && !attacked) {
				p1Target = Random.Range (2, 4);
				if (p1Target == 2 && e2Dead) {
					p1Target = 3;
				}
				if (p1Target == 3 && e3Dead) {
					p1Target = 2;
				}
			} else if (p1Target == 2 && e2Dead && !attacked) {
				int x = Random.Range (1, 3);
				if (x == 1) {
					p1Target = 1;
					if (e1Dead) {
						p1Target = 3;
					}
				} else {
					p1Target = 3;
					if (e3Dead) {
						p1Target = 1;
					}
				}
			} else if (p1Target == 3 && e3Dead && !attacked) {
				p1Target = Random.Range (1, 3);
				if (p1Target == 1 && e1Dead) {
					p1Target = 2;
				}
				if (p1Target == 2 && e2Dead) {
					p1Target = 1;
				}
			}
			if (p1SpellTarget == "One") {
				newsText1.text = ("Player 1 Attacks Enemy " + p1Target + "!");
				if (!attacked && p1Target == 1) {
					if (spellSpecial1 == "Undead" && success1_1 && enemyType1 == "Undead") {
						spellDamage1 = (int)(spellDamage1 * 1.1);
						newsText3.text = "Bonus Damage to Undead!";
						//Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!");
					} else if (spellSpecial1 == "Burn" && success1_1 && enemy1Status == "None") {
						enemy1Status = "Burned";
						newsText3.text = "Enemy 1 is burned!";
					} else if (spellSpecial1 == "Freeze" && success1_1 && enemy1Status == "None") {
						enemy1Status = "Frozen";
						newsText3.text = "Enemy 1 is frozen!";
					} else {
						newsText3.text = " ";
					}
					enemy1HP = enemy1HP - spellDamage1;
					e1DamageText.CreateNumber (spellDamage1);
					player1MP = player1MP - mpCost1;
					attacked = true;
				} else if (!attacked && p1Target == 2) {
					if (spellSpecial1 == "Undead" && success1_1 && enemyType2 == "Undead") {
						spellDamage1 = (int)(spellDamage1 * 1.1);
						newsText3.text = "Bonus Damage to Undead!";
					} else if (spellSpecial1 == "Burn" && success1_1 && enemy2Status == "None") {
						enemy2Status = "Burned";
						newsText3.text = "Enemy 2 is burned!";
					} else if (spellSpecial1 == "Freeze" && success1_1 && enemy2Status == "None") {
						enemy2Status = "Frozen";
						newsText3.text = "Enemy 2 is frozen!";
					} else {
						newsText3.text = " ";
					}
					e2DamageText.CreateNumber (spellDamage1);
					enemy2HP = enemy2HP - spellDamage1;
					player1MP = player1MP - mpCost1;
					attacked = true;
				} else if (!attacked && p1Target == 3) {
					if (spellSpecial1 == "Undead" && success1_1 && enemyType3 == "Undead") {
						spellDamage1 = (int)(spellDamage1 * 1.1);
						newsText3.text = "Bonus Damage to Undead!";
					} else if (spellSpecial1 == "Burn" && success1_1 && enemy3Status == "None") {
						enemy3Status = "Burned";
						newsText3.text = "Enemy 3 is burned!";
					} else if (spellSpecial1 == "Freeze" && success1_1 && enemy3Status == "None") {
						enemy3Status = "Frozen";
						newsText3.text = "Enemy 3 is frozen!";
					} else {
						newsText3.text = " ";
					}
					e3DamageText.CreateNumber (spellDamage1);
					enemy3HP = enemy3HP - spellDamage1;
					player1MP = player1MP - mpCost1;
					attacked = true;
				}
				if (p1Target == 1 && enemy1HP <= 0 && !e1Dead) {
					newsText2.text = ("Enemy 1 is defeated!");
					enemy1.SetActive (false);
					enemy1Status = "None";
					slider1.SetActive (false);
					e1Dead = true;
				} else if (p1Target == 2 && enemy2HP <= 0 && !e2Dead) {
					newsText2.text = ("Enemy 2 is defeated!");
					enemy2.SetActive (false);
					enemy2Status = "None";
					slider2.SetActive (false);
					e2Dead = true;
				} else if (p1Target == 3 && enemy3HP <= 0 && !e3Dead) {
					newsText2.text = ("Enemy 3 is defeated!");
					enemy3.SetActive (false);
					enemy3Status = "None";
					slider3.SetActive (false);
					e3Dead = true;
				} else {
				}
			} else {
				newsText1.text = ("Player 1 Attacks!");
				if (!attacked) {
					if(spellSpecial1 == "Burn"){
						if (success1_1 && enemy1Status != "Burned" && !e1Dead) {
							if (success1_2 && enemy2Status != "Burned" && !e2Dead) {
								if (success1_3 && enemy3Status != "Burned" && !e3Dead) {
									newsText3.text = "Enemies 1, 2, and 3 are burned!";
									enemy1Status = "Burned";
									enemy2Status = "Burned";
									enemy3Status = "Burned";
								} else if(!success1_3 && !e3Dead) {
									newsText3.text = "Enemies 1 and 2 are burned!";
									enemy1Status = "Burned";
									enemy2Status = "Burned";
								}
							} else if (success1_3 && enemy3Status != "Burned" && !e3Dead) {
								newsText3.text = "Enemies 1 and 3 are burned!";
								enemy1Status = "Burned";
								enemy3Status = "Burned";
							} else if (!success1_2 && !e2Dead) {
								newsText3.text = "Enemy 1 is burned!";
								enemy1Status = "Burned";
							}
						} else if (success1_2 && enemy2Status != "Burned" && !e2Dead) {
							if (success1_3 && enemy3Status != "Burned") {
								newsText3.text = "Enemies 2 and 3 are burned!";
								enemy2Status = "Burned";
								enemy3Status = "Burned";
							} else if (!success1_3 && !e3Dead) {
								newsText3.text = "Enemy 2 is burned!";
								enemy2Status = "Burned";
							}
						} else if (success1_3 && enemy3Status != "Burned" && !e3Dead) {
							newsText3.text = "Enemy 3 is burned!";
							enemy3Status = "Burned";
						} else if (!success1_3){
						}
					}
					else if(spellSpecial1 == "Freeze"){
						if (success1_1 && enemy1Status != "Frozen" && !e1Dead) {
							if (success1_2 && enemy2Status != "Frozen" && !e2Dead) {
								if (success1_3 && enemy3Status != "Frozen" && !e3Dead) {
									newsText3.text = "Enemies 1, 2, and 3 are frozen!";
									enemy1Status = "Frozen";
									enemy2Status = "Frozen";
									enemy3Status = "Frozen";
								} else if (!success1_3 && !e3Dead) {
									newsText3.text = "Enemies 1 and 2 are frozen!";
									enemy1Status = "Frozen";
									enemy2Status = "Frozen";
								}
							} else if (success1_3 && enemy3Status != "Frozen" && !e3Dead) {
								newsText3.text = "Enemies 1 and 3 are frozen!";
								enemy1Status = "Frozen";
								enemy3Status = "Frozen";
							} else if (!success1_3 && !e3Dead) {
								newsText3.text = "Enemy 1 is frozen!";
								enemy1Status = "Frozen";
							}
						} else if (success1_2 && enemy2Status != "Frozen" && !e2Dead) {
							if (success1_3 && enemy3Status != "Frozen" && !e3Dead) {
								newsText3.text = "Enemies 2 and 3 are frozen!";
								enemy2Status = "Frozen";
								enemy3Status = "Frozen";
							} else if (!success1_3 && !e3Dead) {
								newsText3.text = "Enemy 2 is frozen!";
								enemy2Status = "Frozen";
							}
						} else if (success1_3 && enemy3Status != "Frozen" && !e3Dead) {
							newsText3.text = "Enemy 3 is frozen!";
							enemy3Status = "Frozen";
						} else if (!success1_3) {
						}
					}
					if ((!success1_1 || e1Dead) && (!success1_2 || e2Dead) && (!success1_3 || e3Dead)) {
						newsText3.text = " ";
					}

					int undeadBonusDamage = (int)(spellDamage1 * 1.1);
					if (enemyType1 == "Undead") {
						enemy1HP = enemy1HP - undeadBonusDamage;
						e1DamageText.CreateNumber (undeadBonusDamage);
						newsText3.text = "Bonus Damage to Undead!";
					} else {
						enemy1HP = enemy1HP - spellDamage1;
						e1DamageText.CreateNumber (spellDamage1);
						newsText3.text = " ";
					}
					if (enemyType2 == "Undead") {
						enemy2HP = enemy2HP - undeadBonusDamage;
						newsText3.text = "Bonus Damage to Undead!";
						e2DamageText.CreateNumber (undeadBonusDamage);
					} else {
						enemy2HP = enemy2HP - spellDamage1;
						newsText3.text = " ";
						e2DamageText.CreateNumber (spellDamage1);
					}
					if (enemyType3 == "Undead") {
						enemy3HP = enemy3HP - undeadBonusDamage;
						newsText3.text = "Bonus Damage to Undead!";
						e3DamageText.CreateNumber (undeadBonusDamage);
					} else {
						enemy3HP = enemy3HP - spellDamage1;
						e3DamageText.CreateNumber (spellDamage1);
						newsText3.text = " ";
					}
					player1MP = player1MP - mpCost1;
					attacked = true;
				}
				if (enemy1HP <= 0 && !e1Dead) {
					if ((enemy2HP > 0 || e2Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 1 is defeated!");
						enemy1.SetActive (false);
						enemy1Status = "None";
						slider1.SetActive (false);
						e1Dead = true;
					}
					if ((enemy2HP <= 0 && !e2Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 1 and 2 are defeated!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy1Status = "None";
						enemy2Status = "None";
						e1Dead = true;
						e2Dead = true;
					}
					if ((enemy2HP > 0 || e2Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 1 and 3 are defeated!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						enemy1Status = "None";
						enemy3Status = "None";
						e1Dead = true;
						e3Dead = true;
					}
					if ((enemy2HP <= 0 && !e2Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 1, 2, and 3 are defeated! Total Knockout!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						enemy1Status = "None";
						enemy2Status = "None";
						enemy3Status = "None";
						e1Dead = true;
						e2Dead = true;
						e3Dead = true;
					}
				} else if (enemy2HP <= 0 && !e2Dead) {
					if ((enemy1HP > 0 || e1Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 2 is defeated!");
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy2Status = "None";
						e2Dead = true;
					}
					if ((enemy1HP > 0 || e1Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 2 and 3 are defeated!");
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						enemy2Status = "None";
						enemy3Status = "None";
						e2Dead = true;
						e3Dead = true;
					}
				} else if (enemy3HP <= 0 && !e3Dead) {
					newsText2.text = ("Enemy 3 is defeated!");
					enemy3.SetActive (false);
					slider3.SetActive (false);
					enemy3Status = "None";
					e3Dead = true;
				}
			}
		} else if (phase == "Player2Attacks" && p2Tired == 1) {
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			newsText1.text = "Player 2 is tired from using their Desperation Spell!";
		} else if (phase == "Player2Attacks") {
			p1Target = 0;
			spellDamage1 = 0;
			mpCost1 = 0;
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			if (p2Target == 1 && e1Dead && !attacked) {
				p2Target = Random.Range (2, 4);
				if (p2Target == 2 && e2Dead) {
					p2Target = 3;
				}
				if (p2Target == 3 && e3Dead) {
					p2Target = 2;
				}
			} else if (p2Target == 2 && e2Dead && !attacked) {
				int x = Random.Range (1, 3);
				if (x == 1) {
					p2Target = 1;
					if (e1Dead) {
						p2Target = 3;
					}
				} else {
					p2Target = 3;
					if (e3Dead) {
						p2Target = 1;
					}
				}
			} else if (p2Target == 3 && e3Dead && !attacked) {
				p2Target = Random.Range (1, 3);
				if (p2Target == 1 && e1Dead) {
					p2Target = 2;
				}
				if (p2Target == 2 && e2Dead) {
					p2Target = 1;
				}
			}
			if (p2SpellTarget == "One") {
				newsText1.text = ("Player 2 Attacks Enemy " + p2Target + "!");
				if (!attacked && p2Target == 1) {
					enemy1HP = enemy1HP - spellDamage2;
					e1DamageText.CreateNumber (spellDamage2);
					player2MP = player2MP - mpCost2;
					attacked = true;
					if (spellSpecial2 == "Heal" && success2_1) {
						int healed = (int)(spellDamage2 * 0.25);
						player2HP += healed;
						newsText3.text = "Player 2 Healed " + healed + " Damage";
						p2DamageText.CreateNumber (healed * -1);
					} else if (spellSpecial2 == "Burn" && success2_1 && enemy1Status == "None") {
						enemy1Status = "Burned";
						newsText3.text = "Enemy 3 is burned!";
					} else if (spellSpecial2 == "Freeze" && success2_1 && enemy1Status == "None") {
						enemy1Status = "Frozen";
						newsText3.text = "Enemy 3 is frozen!";
					} else {
						newsText3.text = " ";
					}
				} else if (!attacked && p2Target == 2) {
					enemy2HP = enemy2HP - spellDamage2;
					e2DamageText.CreateNumber (spellDamage2);
					player2MP = player2MP - mpCost2;
					attacked = true;
					if (spellSpecial2 == "Heal" && success2_1) {
						int healed = (int)(spellDamage2 * 0.25);
						player2HP += healed;
						newsText3.text = "Player 2 Healed " + healed + " Damage";
						p2DamageText.CreateNumber (healed * -1);
					} else if (spellSpecial2 == "Burn" && success2_1 && enemy2Status == "None") {
						enemy3Status = "Burned";
						newsText3.text = "Enemy 2 is burned!";
					} else if (spellSpecial2 == "Freeze" && success2_1 && enemy2Status == "None") {
						enemy2Status = "Frozen";
						newsText3.text = "Enemy 2 is frozen!";
					} else {
						newsText3.text = " ";
					}
				} else if (!attacked && p2Target == 3) {
					enemy3HP = enemy3HP - spellDamage2;
					e3DamageText.CreateNumber (spellDamage2);
					player2MP = player2MP - mpCost2;
					attacked = true;
					if (spellSpecial2 == "Heal" && success2_1) {
						int healed = (int)(spellDamage2 * 0.25);
						player2HP += healed;
						newsText3.text = "Player 2 Healed " + healed + " Damage";
						p2DamageText.CreateNumber (healed * -1);
					} else if (spellSpecial2 == "Burn" && success2_1 && enemy3Status == "None") {
						enemy3Status = "Burned";
						newsText3.text = "Enemy 3 is burned!";
					} else if (spellSpecial2 == "Freeze" && success2_1 && enemy3Status == "None") {
						enemy3Status = "Frozen";
						newsText3.text = "Enemy 3 is frozen!";
					} else {
						newsText3.text = " ";
					}
				}
				if (p2Target == 1 && enemy1HP <= 0 && !e1Dead) {
					newsText2.text = ("Enemy 1 is defeated!");
					enemy1.SetActive (false);
					slider1.SetActive (false);
					enemy1Status = "None";
					e1Dead = true;
				} else if (p2Target == 2 && enemy2HP <= 0 && !e2Dead) {
					newsText2.text = ("Enemy 2 is defeated!");
					enemy2.SetActive (false);
					slider2.SetActive (false);
					enemy2Status = "None";
					e2Dead = true;
				} else if (p2Target == 3 && enemy3HP <= 0 && !e3Dead) {
					newsText2.text = ("Enemy 3 is defeated!");
					enemy3.SetActive (false);
					slider3.SetActive (false);
					enemy3Status = "None";
					e3Dead = true;
				} else {
				}
			} else {
				newsText1.text = ("Player 2 Attacks!");
				if (!attacked) {
					if(spellSpecial2 == "Burn"){
						if (success2_1 && enemy1Status != "Burned" && !e1Dead) {
							if (success2_2 && enemy2Status != "Burned" && !e2Dead) {
								if (success2_3 && enemy3Status != "Burned" && !e3Dead) {
									newsText3.text = "Enemies 1, 2, and 3 are burned!";
									enemy1Status = "Burned";
									enemy2Status = "Burned";
									enemy3Status = "Burned";
								} else if (!success2_3 && !e3Dead) {
									newsText3.text = "Enemies 1 and 2 are burned!";
									enemy1Status = "Burned";
									enemy2Status = "Burned";
								}
							} else if (success2_3 && enemy3Status != "Burned" && !e3Dead) {
								newsText3.text = "Enemies 1 and 3 are burned!";
								enemy1Status = "Burned";
								enemy3Status = "Burned";
							} else if (!success2_3 && !e3Dead) {
								newsText3.text = "Enemy 1 is burned!";
								enemy1Status = "Burned";
							}
						} else if (success2_2 && enemy2Status != "Burned" && !e2Dead) {
							if (success2_3 && enemy3Status != "Burned" && !e3Dead) {
								newsText3.text = "Enemies 2 and 3 are burned!";
								enemy2Status = "Burned";
								enemy3Status = "Burned";
							} else if (!success2_3 && !e3Dead) {
								newsText3.text = "Enemy 2 is burned!";
								enemy2Status = "Burned";
							}
						} else if (success2_3 && enemy3Status != "Burned" && !e3Dead) {
							newsText3.text = "Enemy 3 is burned!";
							enemy3Status = "Burned";
						} else if(!success2_3) {
						}
					}
					else if(spellSpecial2 == "Freeze"){
						if (success2_1 && enemy1Status != "Frozen" && !e1Dead) {
							if (success2_2 && enemy2Status != "Frozen" && !e2Dead) {
								if (success2_3 && enemy3Status != "Frozen" && !e3Dead) {
									newsText3.text = "Enemies 1, 2, and 3 are frozen!";
									enemy1Status = "Frozen";
									enemy2Status = "Frozen";
									enemy3Status = "Frozen";
								} else if (!success2_3 && !e3Dead) {
									newsText3.text = "Enemies 1 and 2 are frozen!";
									enemy1Status = "Frozen";
									enemy2Status = "Frozen";
								}
							} else if (success2_3 && enemy3Status != "Frozen" && !e3Dead) {
								newsText3.text = "Enemies 1 and 3 are frozen!";
								enemy1Status = "Frozen";
								enemy3Status = "Frozen";
							} else if (!success2_3 && !e3Dead){
								newsText3.text = "Enemy 1 is frozen!";
								enemy1Status = "Frozen";
							}
						} else if (success2_2 && enemy2Status != "Frozen" && !e2Dead) {
							if (success2_3 && enemy3Status != "Frozen" && !e3Dead) {
								newsText3.text = "Enemies 2 and 3 are frozen!";
								enemy2Status = "Frozen";
								enemy3Status = "Frozen";
							} else if (!success2_3 && !e3Dead) {
								newsText3.text = "Enemy 2 is frozen!";
								enemy2Status = "Frozen";
							}
						} else if (success2_3 && enemy3Status != "Frozen" && !e3Dead) {
							newsText3.text = "Enemy 3 is frozen!";
							enemy3Status = "Frozen";
						} else if (!success2_3) {
						}
					}
					if ((!success2_1 || e1Dead) && (!success2_2 || e2Dead) && (!success2_3 || e3Dead)) {
						newsText3.text = " ";
					}
					enemy1HP = enemy1HP - spellDamage2;
					enemy2HP = enemy2HP - spellDamage2;
					enemy3HP = enemy3HP - spellDamage2;
					e1DamageText.CreateNumber (spellDamage2);
					e2DamageText.CreateNumber (spellDamage2);
					e3DamageText.CreateNumber (spellDamage2);
					player2MP = player2MP - mpCost2;
					attacked = true;
					if (spellSpecial2 == "Heal" && success2_1) {
						int healed = (int)(spellDamage2 * 0.25) * 3;
						player2HP += healed;
						newsText3.text = "Player 2 Healed " + healed + " Damage";
						p2DamageText.CreateNumber (healed * -1);
					}
				}
				if (enemy1HP <= 0 && !e1Dead) {
					if ((enemy2HP > 0 || e2Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 1 is defeated!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy1Status = "None";
						e1Dead = true;
					}
					if ((enemy2HP <= 0 && !e2Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 1 and 2 are defeated!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy1Status = "None";
						enemy2Status = "None";
						e1Dead = true;
						e2Dead = true;
					}
					if ((enemy2HP > 0 || e2Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 1 and 3 are defeated!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						enemy1Status = "None";
						enemy3Status = "None";
						e1Dead = true;
						e3Dead = true;
					}
					if ((enemy2HP <= 0 && !e2Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 1, 2, and 3 are defeated! Total Knockout!");
						enemy1.SetActive (false);
						slider1.SetActive (false);
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						enemy1Status = "None";
						enemy2Status = "None";
						enemy3Status = "None";
						e1Dead = true;
						e2Dead = true;
						e3Dead = true;
					}
				} else if (enemy2HP <= 0 && !e2Dead) {
					if ((enemy1HP > 0 || e1Dead) && (enemy3HP > 0 || e3Dead)) {
						newsText2.text = ("Enemy 2 is defeated!");
						enemy2.SetActive (false);
						slider2.SetActive (false);
						e2Dead = true;
						enemy2Status = "None";
					}
					if ((enemy1HP > 0 || e1Dead) && (enemy3HP <= 0 && !e3Dead)) {
						newsText2.text = ("Enemy 2 and 3 are defeated!");
						enemy2.SetActive (false);
						slider2.SetActive (false);
						enemy3.SetActive (false);
						slider3.SetActive (false);
						e2Dead = true;
						e3Dead = true;
						enemy2Status = "None";
						enemy3Status = "None";
					}
				} else if (enemy3HP <= 0 && !e3Dead) {
					newsText2.text = ("Enemy 3 is defeated!");
					enemy3.SetActive (false);
					slider3.SetActive (false);
					e3Dead = true;
					enemy3Status = "None";
				}
			}
		} else if (phase == "Enemy1Attacks") {
			p2Target = 0;
			spellDamage2 = 0;
			mpCost2 = 0;
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			if (enemy1Status == "Frozen") {
				attacked = true;
				newsText1.text = ("Enemy 1 is Frozen!");
			} else {
				newsText1.text = ("Enemy 1 Attacks! Player " + e1Target + " takes " + e1Damage + " damage!");
			}
			if (p1Dead && !attacked) {
				e1Target = 2;
			}
			if (p2Dead && !attacked) {
				e1Target = 1;
			}
			if (!attacked && e1Target == 1) {
				player1HP = player1HP - e1Damage;
				p1DamageText.CreateNumber (e1Damage);
				attacked = true;
			} else if (!attacked && e1Target == 2) {
				player2HP = player2HP - e1Damage;
				p2DamageText.CreateNumber (e1Damage);
				attacked = true;
			}
			if (e1Target == 1 && player1HP <= 0 && !p1Dead) {
				newsText2.text = ("Player 1 is defeated!");
				player1.SetActive (false);
				p1Dead = true;
			} else if (e1Target == 2 && player2HP <= 0 && !p2Dead) {
				newsText2.text = ("Player 2 is defeated!");
				player2.SetActive (false);
				p2Dead = true;
			}
		} else if (phase == "Enemy2Attacks") {
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			if (enemy2Status == "Frozen") {
				attacked = true;
				newsText1.text = ("Enemy 2 is Frozen!");
			} else {
				newsText1.text = ("Enemy 2 Attacks! Player " + e2Target + " takes " + e2Damage + " damage!");
			}
			if (p1Dead && !attacked) {
				e2Target = 2;
			}
			if (p2Dead && !attacked) {
				e2Target = 1;
			}
			if (!attacked && e2Target == 1) {
				player1HP = player1HP - e2Damage;
				p1DamageText.CreateNumber (e2Damage);
				attacked = true;
			} else if (!attacked && e2Target == 2) {
				player2HP = player2HP - e2Damage;
				p2DamageText.CreateNumber (e2Damage);
				attacked = true;
			}
			if (e2Target == 1 && player1HP <= 0 && !p1Dead) {
				newsText2.text = ("Player 1 is defeated!");
				player1.SetActive (false);
				p1Dead = true;
			} else if (e2Target == 2 && player2HP <= 0 && !p2Dead) {
				newsText2.text = ("Player 2 is defeated!");
				player2.SetActive (false);
				p2Dead = true;
			}
		} else if (phase == "Enemy3Attacks") {
			whoText.text = (" ");
			chooseSpellP1.SetActive (false);
			chooseSpellP2.SetActive (false);
			chooseTargetP1.SetActive (false);
			chooseTargetP2.SetActive (false);
			nextButton.SetActive (true);
			news.SetActive (true);
			if (enemy3Status == "Frozen") {
				attacked = true;
				newsText1.text = ("Enemy 3 is Frozen!");
			} else {
				newsText1.text = ("Enemy 3 Attacks! Player " + e3Target + " takes " + e3Damage + " damage!");
			}
			if (p1Dead && !attacked) {
				e3Target = 2;
			}
			if (p2Dead && !attacked) {
				e3Target = 1;
			}
			if (!attacked && e3Target == 1) {
				player1HP = player1HP - e3Damage;
				p1DamageText.CreateNumber (e3Damage);
				attacked = true;
			} else if (!attacked && e3Target == 2) {
				player2HP = player2HP - e3Damage;
				p2DamageText.CreateNumber (e3Damage);
				attacked = true;
			}
			if (e3Target == 1 && player1HP <= 0 && !p1Dead) {
				newsText2.text = ("Player 1 is defeated!");
				player1.SetActive (false);
				p1Dead = true;
			} else if (e3Target == 2 && player2HP <= 0 && !p2Dead) {
				newsText2.text = ("Player 2 is defeated!");
				player2.SetActive (false);
				p2Dead = true;
			}
		} else if (phase == "CheckForVictoryOrLoss") {
			if (p1Dead && p2Dead) {
				loss = true;
				finalText.text = "You Died!";
				nextButton.SetActive (false);
			} else if (e1Dead && e2Dead && e3Dead) {
				victory = true;
				finalText.text = "You Win!";
				nextButton.SetActive (true);
			}
			if (!victory && !loss) {
				ChangePhase ();
			}
		} else if (phase == "StatusCheck1") {
			if (enemy1Status == "Burned" && !attacked) {
				int burnDamage = (int)(enemy1MaxHP * 0.05);
				enemy1HP -= burnDamage;
				e1DamageText.CreateNumber (burnDamage);
				newsText1.text = "Enemy 1 takes " + burnDamage + " damage from the burn!";
				attacked = true;
			} else if (enemy1Status == "Frozen" && !attacked) {
				float freezeChance = Random.Range (0f, 1f);
				Debug.Log (freezeChance);
				if (freezeChance <= 0.3f && !attacked) {
					enemy1Status = "None";
					newsText1.text = "Enemy 1 is no longer frozen!";
					e1Thawed = true;
				} else if (freezeChance > 0.3f && !attacked) {
					ChangePhase ();
				}
				attacked = true;
			} else if(enemy1Status == "None" && !e1Thawed){
				ChangePhase ();
			}
			if (enemy1HP <= 0 && !e1Dead) {
				newsText2.text = ("Enemy 1 is defeated!");
				enemy1.SetActive (false);
				enemy1Status = "None";
				slider1.SetActive (false);
				e1Dead = true;
			}
		} else if (phase == "StatusCheck2") {
			if (enemy2Status == "Burned" && !attacked) {
				int burnDamage = (int)(enemy2MaxHP * 0.05);
				enemy2HP -= burnDamage;
				e2DamageText.CreateNumber (burnDamage);
				newsText1.text = "Enemy 2 takes " + burnDamage + " damage from the burn!";
				attacked = true;
			} else if (enemy2Status == "Frozen" && !attacked) {
				float freezeChance = Random.Range (0f, 1f);
				Debug.Log (freezeChance);
				if (freezeChance <= 0.3f && !attacked) {
					enemy2Status = "None";
					newsText1.text = "Enemy 2 is no longer frozen!";
					e2Thawed = true;
				} else if (freezeChance > 0.3f && !attacked) {
					ChangePhase ();
				}
				attacked = true;
			} else if(enemy2Status == "None" && !e2Thawed){
				ChangePhase ();
			}
			if (enemy2HP <= 0 && !e2Dead) {
				newsText2.text = ("Enemy 2 is defeated!");
				enemy2.SetActive (false);
				enemy2Status = "None";
				slider2.SetActive (false);
				e2Dead = true;
			}
		} else if (phase == "StatusCheck3") {
			if (enemy3Status == "Burned" && !attacked) {
				int burnDamage = (int)(enemy3MaxHP * 0.05);
				enemy3HP -= burnDamage;
				e3DamageText.CreateNumber (burnDamage);
				newsText1.text = "Enemy 3 takes " + burnDamage + " damage from the burn!";
				attacked = true;
			} else if (enemy3Status == "Frozen" && !attacked) {
				float freezeChance = Random.Range (0f, 1f);
				Debug.Log (freezeChance);
				if (freezeChance <= 0.3f && !attacked) {
					enemy3Status = "None";
					newsText1.text = "Enemy 3 is no longer frozen!";
					e3Thawed = true;
				} else if (freezeChance > 0.3f && !attacked) {
					ChangePhase ();
				}
				attacked = true;
			} else if(enemy3Status == "None" && !e3Thawed){
				ChangePhase ();
			}
			if (enemy3HP <= 0 && !e3Dead) {
				newsText2.text = ("Enemy 3 is defeated!");
				enemy3.SetActive (false);
				enemy3Status = "None";
				slider3.SetActive (false);
				e3Dead = true;
			}
		}

	}

	public void MouseHover(Button button){
		if (button.name == "P1 Spell 1") {
			elementText.text = (player1Spell1.spell_element);
			damageText.text = (player1Spell1.spell_damage + " Damage");
			mpText.text = (player1Spell1.spell_cost + " MP");
			bonusText.text = (player1Spell1.spell_special + "Chance: " + player1Spell1.spell_special_chance);
			targetText.text = "Target " + player1Spell1.spell_damage_target;
            desperationText.text = " ";
		}
		if (button.name == "P1 Spell 2") {
			elementText.text = (player1Spell2.spell_element);
			damageText.text = (player1Spell2.spell_damage + " Damage");
			mpText.text = (player1Spell2.spell_cost + " MP");
			bonusText.text = (player1Spell2.spell_special + "Chance: " + player1Spell2.spell_special_chance);
			targetText.text = "Target " + player1Spell2.spell_damage_target;
            desperationText.text = " ";
		}
		if (button.name == "P1 Spell 3") {
			elementText.text = (player1Spell3.spell_element);
			damageText.text = (player1Spell3.spell_damage + " Damage");
			mpText.text = (player1Spell3.spell_cost + " MP");
			bonusText.text = (player1Spell3.spell_special + "Chance: " + player1Spell3.spell_special_chance);
			targetText.text = "Target " + player1Spell3.spell_damage_target;
            desperationText.text = " ";
		}
		if (button.name == "P1 Spell Basic") {
			elementText.text = (player1Spell0.spell_element);
			damageText.text = (player1Spell0.spell_damage + " Damage");
			mpText.text = (player1Spell0.spell_cost + " MP");
			bonusText.text = (player1Spell0.spell_special + "Chance: " + player1Spell0.spell_special_chance);
			targetText.text = "Target " + player1Spell0.spell_damage_target;
            desperationText.text = "Basic Spell:";
		}
		if (button.name == "P1 Spell Desperation") {
			elementText.text = (player1Spell4.spell_element);
			damageText.text = (player1Spell4.spell_damage + " Damage");
			mpText.text = (player1Spell4.spell_cost + " MP");
			bonusText.text = (player1Spell4.spell_special + "Chance: " + player1Spell4.spell_special_chance);
			targetText.text = "Target " + player1Spell4.spell_damage_target;
            desperationText.text = "Desperation Spell:";
		}
		if (button.name == "P2 Spell 1") {
			elementText.text = (player2Spell1.spell_element);
			damageText.text = (player2Spell1.spell_damage + " Damage");
			mpText.text = (player2Spell1.spell_cost + " MP");
			bonusText.text = (player2Spell1.spell_special + "Chance: " + player2Spell1.spell_special_chance);
			targetText.text = "Target " + player2Spell1.spell_damage_target;
			desperationText.text = " ";
		}
		if (button.name == "P2 Spell 2") {
			elementText.text = (player2Spell2.spell_element);
			damageText.text = (player2Spell2.spell_damage + " Damage");
			mpText.text = (player2Spell2.spell_cost + " MP");
			bonusText.text = (player2Spell2.spell_special + "Chance: " + player2Spell2.spell_special_chance);
			targetText.text = "Target " + player2Spell2.spell_damage_target;
			desperationText.text = " ";
		}
		if (button.name == "P2 Spell 3") {
			elementText.text = (player2Spell3.spell_element);
			damageText.text = (player2Spell3.spell_damage + " Damage");
			mpText.text = (player2Spell3.spell_cost + " MP");
			bonusText.text = (player2Spell3.spell_special + "Chance: " + player2Spell3.spell_special_chance);
            desperationText.text = " ";
		}
		if (button.name == "P2 Spell Desperation") {
			elementText.text = (player2Spell4.spell_element);
			damageText.text = (player2Spell4.spell_damage + " Damage");
			mpText.text = (player2Spell4.spell_cost + " MP");
			bonusText.text = (player2Spell4.spell_special + "Chance: " + player2Spell4.spell_special_chance);
			targetText.text = "Target " + player2Spell4.spell_damage_target;
			desperationText.text = "Desperation Spell:";
		}
		if (button.name == "P2 Spell Basic") {
			elementText.text = (player2Spell0.spell_element);
			damageText.text = (player2Spell0.spell_damage + " Damage");
			mpText.text = (player2Spell0.spell_cost + " MP");
			bonusText.text = (player2Spell0.spell_special + "Chance: " + player2Spell0.spell_special_chance);
			targetText.text = "Target " + player2Spell0.spell_damage_target;
			desperationText.text = "Basic Spell:";
		}
	}

	public void TargetEnemy(Button button){
		if (button.name == "P1 Target 1") {
			p1Target = 1;
			p1SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P1 Target 2") {
			p1Target = 2;
			p1SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P1 Target 3") {
			p1Target = 3;
			p1SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P1 Target All") {
			p1Target = 0;
			p1SpellTarget = "All";
			ChangePhase ();
		}
		if (button.name == "P2 Target 1") {
			p2Target = 1;
			p2SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P2 Target 2") {
			p2Target = 2;
			p2SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P2 Target 3") {
			p2Target = 3;
			p2SpellTarget = "One";
			ChangePhase ();
		}
		if (button.name == "P2 Target All") {
			p2Target = 0;
			p2SpellTarget = "All";
			ChangePhase ();
		}
	}

	public void ChooseSpell(Button button){
		if (button.name == "P1 Spell 1") {
			spellDamage1 = p1SpellDamage1;
			healingPercent1 = player1Spell1.spell_healing_percent;
			mpCost1 = p1SpellCost1;
			p1SpellTarget = player1Spell1.spell_damage_target;
			spellSpecial1 = player1Spell1.spell_special;
			specialChance1 = player1Spell1.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P1 Spell 2") {
			spellDamage1 = p1SpellDamage2;
			healingPercent1 = player1Spell2.spell_healing_percent;
			mpCost1 = p1SpellCost2;
			p1SpellTarget = player1Spell2.spell_damage_target;
			spellSpecial1 = player1Spell2.spell_special;
			specialChance1 = player1Spell2.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P1 Spell 3") {
			spellDamage1 = p1SpellDamage3;
			healingPercent1 = player1Spell3.spell_healing_percent;
			mpCost1 = p1SpellCost3;
			p1SpellTarget = player1Spell3.spell_damage_target;
			spellSpecial1 = player1Spell3.spell_special;
			specialChance1 = player1Spell3.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P1 Spell Basic") {
			spellDamage1 = player1Spell0.spell_damage;
			healingPercent1 = player1Spell0.spell_healing_percent;
			mpCost1 = player1Spell0.spell_cost;
			p1SpellTarget = player1Spell0.spell_damage_target;
			spellSpecial1 = player1Spell0.spell_special;
			specialChance1 = player1Spell0.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P1 Spell Desperation") {
			spellDamage1 = p1SpellDamage4;
			healingPercent1 = player1Spell4.spell_healing_percent;
			mpCost1 = player1Spell4.spell_cost;
			p1SpellTarget = player1Spell4.spell_damage_target;
			spellSpecial1 = player1Spell4.spell_special;
			specialChance1 = player1Spell4.spell_special_chance;
			desperationUsed1 = true;
			p1Tired = 2;
			ChangePhase ();
		}
		if (button.name == "P2 Spell 1") {
			spellDamage2 = p2SpellDamage1;
			healingPercent2 = player2Spell1.spell_healing_percent;
			mpCost2 = p2SpellCost1;
			p2SpellTarget = player2Spell1.spell_damage_target;
			spellSpecial2 = player2Spell1.spell_special;
			specialChance2 = player2Spell1.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P2 Spell 2") {
			spellDamage2 = p2SpellDamage2;
			healingPercent2 = player2Spell2.spell_healing_percent;
			mpCost2 = p2SpellCost2;
			p2SpellTarget = player2Spell2.spell_damage_target;
			spellSpecial2 = player2Spell2.spell_special;
			specialChance2 = player2Spell2.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P2 Spell 3") {
			spellDamage2 = p2SpellDamage3;
			healingPercent2 = player2Spell3.spell_healing_percent;
			mpCost2 = p2SpellCost3;
			p2SpellTarget = player2Spell3.spell_damage_target;
			spellSpecial2 = player2Spell3.spell_special;
			specialChance2 = player2Spell3.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P2 Spell Basic") {
			spellDamage2 = player2Spell0.spell_damage;
			healingPercent2 = player2Spell0.spell_healing_percent;
			mpCost2 = player2Spell0.spell_cost;
			p2SpellTarget = player2Spell0.spell_damage_target;
			spellSpecial2 = player2Spell0.spell_special;
			specialChance2 = player2Spell0.spell_special_chance;
			ChangePhase ();
		}
		if (button.name == "P2 Spell Desperation") {
			spellDamage2 = p2SpellDamage4;
			healingPercent2 = player2Spell4.spell_healing_percent;
			mpCost2 = player2Spell4.spell_cost;
			p2SpellTarget = player2Spell4.spell_damage_target;
			spellSpecial2 = player2Spell4.spell_special;
			specialChance2 = player2Spell4.spell_special_chance;
			p2Tired = 2;
			desperationUsed2 = true;
			ChangePhase ();
		}
	}

	public void ChangePhase(){
		if (phase == "Player1ChooseSpell") {
			elementText.text = (" ");
			damageText.text = (" ");
			mpText.text = (" ");
			bonusText.text = (" ");
			targetText.text = " ";
            desperationText.text = " ";
			phase = "Player1ChooseTarget";
		} else if (phase == "Player1ChooseTarget") {
			elementText.text = (" ");
			damageText.text = (" ");
			mpText.text = (" ");
			bonusText.text = (" ");
			targetText.text = " ";
            desperationText.text = " ";
			if (!p2Dead) {
				phase = "Player2ChooseSpell";
			} else {
				phase = "Player1Attacks";
			}
		} else if (phase == "Player2ChooseSpell") {
			elementText.text = (" ");
			damageText.text = (" ");
			mpText.text = (" ");
			bonusText.text = (" ");
			targetText.text = " ";
            desperationText.text = " ";
			phase = "Player2ChooseTarget";
		} else if (phase == "Player2ChooseTarget") {
			elementText.text = (" ");
			damageText.text = (" ");
			mpText.text = (" ");
			bonusText.text = (" ");
			targetText.text = " ";
            desperationText.text = " ";
			phase = "BeforeAttacking";
		} else if (phase == "BeforeAttacking") {
			if (!p1Dead) {
				phase = "Player1Attacks";
			} else {
				phase = "Player2Attacks";
			}
		} else if (phase == "Player1Attacks") {
			newsText1.text = " ";
			newsText2.text = " ";
			if (!p2Dead && !(e1Dead && e2Dead && e3Dead)) {
				phase = "Player2Attacks";
			} else if (!e1Dead) {
				phase = "Enemy1Attacks";
			} else if (!e2Dead) {
				phase = "Enemy2Attacks";
			} else if (!e3Dead) {
				phase = "Enemy3Attacks";
			} else {
				phase = "CheckForVictoryOrLoss";
			}
		} else if (phase == "Player2Attacks") {
			newsText1.text = " ";
			newsText2.text = " ";
			if (!e1Dead) {
				phase = "Enemy1Attacks";
			} else if (!e2Dead) {
				phase = "Enemy2Attacks";
			} else if (!e3Dead) {
				phase = "Enemy3Attacks";
			} else {
				phase = "CheckForVictoryOrLoss";
			}
		} else if (phase == "Enemy1Attacks") {
			newsText1.text = " ";
			newsText2.text = " ";
			if (!e2Dead) {
				phase = "Enemy2Attacks";
			} else if (!e3Dead) {
				phase = "Enemy3Attacks";
			} else {
				phase = "CheckForVictoryOrLoss";
			}
		} else if (phase == "Enemy2Attacks") {
			newsText1.text = " ";
			newsText2.text = " ";
			if (!e3Dead) {
				phase = "Enemy3Attacks";
			} else {
				phase = "CheckForVictoryOrLoss";
			}
		} else if (phase == "Enemy3Attacks") {
			elementText.text = (" ");
			damageText.text = (" ");
			mpText.text = (" ");
			bonusText.text = (" ");
			newsText1.text = " ";
			newsText2.text = " ";
			targetText.text = " ";
            desperationText.text = " ";
			phase = "CheckForVictoryOrLoss";
		} else if (phase == "StatusCheck1") {
			phase = "StatusCheck2";
		} else if (phase == "StatusCheck2") {
			phase = "StatusCheck3";
		} else if (phase == "StatusCheck3") {
			phase = "BeforeChoosing";
		} else if (phase == "CheckForVictoryOrLoss" && !victory) {
			if (!victory && !loss && !p1Dead) {
				player1MP += 5;
				if (player1MP > player1MaxMP) {
					player1MP = player1MaxMP;
				}
				if (!p2Dead) {
					player2MP += 5;
					if (player2MP > player2MaxMP) {
						player2MP = player2MaxMP;
					}
				}
			} else if (!victory && !loss && !p2Dead) {
				player2MP += 5;
				if (player2MP > player2MaxMP) {
					player2MP = player2MaxMP;
				}
			}
			phase = "StatusCheck1";
		}else if (phase == "CheckForVictoryOrLoss" && victory) {
			enemy1HP = enemy1MaxHP;
			enemy2HP = enemy2MaxHP;
			enemy3HP = enemy3MaxHP;
			enemy1Status = "None";
			enemy2Status = "None";
			enemy3Status = "None";
			e1Dead = false;
			e2Dead = false;
			e3Dead = false;
			victory = false;
			SceneManager.LoadScene ("Overworld");
		} else if (phase == "BeforeChoosing") {
			if (!p1Dead && p1Tired != 1) {
				phase = "Player1ChooseSpell";
			} else if (p2Tired != 1) {
				phase = "Player2ChooseSpell";
			} else if (!p1Dead) {
				phase = "Player1Attacks";
			} else {
				phase = "Player2Attacks";
			}
		}
		attacked = false;
		newsText3.text = " ";
	}
}
