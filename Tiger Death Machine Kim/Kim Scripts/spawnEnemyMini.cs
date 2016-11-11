using UnityEngine;
using System.Collections;

public class spawnEnemyMini : MonoBehaviour {

	bool isSpawning = false;
	public float minTime = 1f;
	public float maxTime = 4f;
	public GameObject[] enemies;
	public GameObject enemy;

	IEnumerator SpawnObject (int index, float seconds) {
	
		yield return new WaitForSeconds (seconds);
		Instantiate (enemies [index], transform.position, transform.rotation);

		isSpawning = false;
	}

	void Update () {
		if (!isSpawning) {
			isSpawning = true;
			int enemyIndex = Random.Range (0, enemies.Length);
			StartCoroutine (SpawnObject (enemyIndex, Random.Range (minTime, maxTime)));
		}

	}
}
