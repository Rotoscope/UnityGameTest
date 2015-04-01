using UnityEngine;
using System.Collections;

public class UnitAttributes : MonoBehaviour {
	public int unitHP;
	public int unitAttack;
//	public Transform target;
//	public GameObject enemy;
//	public bool hasEnemy;
	bool attacking;

	// Use this for initialization
	void Start () {
		this.unitHP = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (unitHP <= 0) {
			Death();
		}
	}

	void TakeDamage(int damage) {
		unitHP -= damage;
	}

	void Death() {
		Destroy (this);
	}

	public int GetUnitHP() {
		return this.unitHP;
	}

	public void SetUnitHP(int hp) {
		this.unitHP = hp;
	}

	public int GetUnitAttack() {
		return this.unitAttack;
	}

	public void SetUnitAttack(int att) {
		this.unitAttack = att;
	}
}
