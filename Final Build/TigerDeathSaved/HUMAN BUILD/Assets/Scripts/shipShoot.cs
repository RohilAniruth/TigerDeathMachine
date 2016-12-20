using UnityEngine;
using System.Collections;

public class shipShoot : MonoBehaviour {

    

	public GameObject bullet;
	private bool canFire = true;
	public AudioClip yo;

	public float rateOfFire = .4f;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
        
if (Input.GetMouseButton(0) && canFire == true) {
			canFire = false;
			StartCoroutine ("reload");
			GameObject temp = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 1000);
			AudioSource.PlayClipAtPoint (yo, transform.position);
		}
	}

	IEnumerator reload() {
		yield return new WaitForSeconds (rateOfFire);
		canFire = true;
	}
}