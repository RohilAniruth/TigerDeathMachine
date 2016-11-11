using UnityEngine;
using System.Collections;

public class spawnEnemy : MonoBehaviour {


	public GameObject enemy1;
	void Start (){
		InvokeRepeating("SpawnEnemy", 0f, 30f);
	}

	void SpawnEnemy() {
		Instantiate (enemy1, transform.position, transform.rotation);
	}
		
}
