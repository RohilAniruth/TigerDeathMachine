using UnityEngine;
using System.Collections;

public class ShipKillBullet : MonoBehaviour {

	public GameObject bullet;
	private bool canFire = true;

	public float rateOfFire = .5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E) && canFire == true) {
			canFire = false;
			StartCoroutine ("reload");
			GameObject temp = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			//temp.GetComponent<Rigidbody2D> ().AddForce (Vector3.up);
		}
	}
	IEnumerator reload () {
		yield return new WaitForSeconds (rateOfFire);
		canFire = true;
	}
}
