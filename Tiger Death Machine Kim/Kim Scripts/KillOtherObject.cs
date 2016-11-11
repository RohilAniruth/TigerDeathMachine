using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour {

//	public GameObject bullet;
//	public GameObject enemy;
	// Update is called once per frame

	void OnCollisionEnter2D (Collision2D otherCollider) {
		Debug.Log ("Hit!");
		if (otherCollider.gameObject.CompareTag ("bullets")) {
			Destroy (gameObject);
			Destroy (otherCollider.gameObject);
		}
//		if (bullet.gameObject.tag == "bullet (1) 1")
//		Destroy (enemy.gameObject);
//		Destroy (bullet.gameObject);

		//Get score object and add score
		GameObject scoreH = GameObject.Find("Canvas");
		scoreH.GetComponent<scoreTracker> ().addScore (1);
	}

}
