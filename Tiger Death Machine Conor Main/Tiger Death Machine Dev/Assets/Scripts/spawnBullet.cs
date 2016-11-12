using UnityEngine;
using System.Collections;

public class spawnBullet : MonoBehaviour {

	public GameObject bullet;
	//public AudioClip yo;

	// Update is called once per frame
	void Update () {
		//		if (Input.GetKeyDown( KeyCode.T) ) {
		//			Debug.Log ("make tracks");
		//			// spawn a tractorFront prefab here
		//			Instantiate(tractor);
		//		}

		if (Input.GetKeyDown( KeyCode.P ) ) {
			GameObject temp = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 1000);
			//AudioSource.PlayClipAtPoint (yo, transform.position);

		}
		//DestroyImmediate (bullet, true);
	}
}