using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject zombiePrefab;
	public int spawnedObjects;
	public GameObject player;
	public bool spawn;
	int minWait;
	int maxWait;
	int waitTime;

	// Use this for initialization
	void Start () {
		minWait = 1;
		maxWait = 10;
		waitTime = Random.Range(minWait, maxWait);
		spawn = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (spawn) {
			Spawn ();
		}
	}

	void Spawn() {
		Instantiate (zombiePrefab, transform.position, transform.rotation);
		spawnedObjects++;
		NewWaitTime ();
		spawn = false;
		SetSpawn ();
	}

	IEnumerator SetSpawn() {
		yield return new WaitForSeconds(waitTime);
		spawn = true;
	}

	void NewWaitTime() {
		waitTime = Random.Range(minWait, maxWait);

	}

}
