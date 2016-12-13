using UnityEngine;
using System.Collections;

public class shipShoot : MonoBehaviour {

	public GameObject bullet;
	private bool canFire = true;
	public AudioClip yo;

	public GunRotation g_Script;

	public float rateOfFire = .4f;

	public Transform _Firepoint;

	public LayerMask hitWhat;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//Shoot();
		}
	}

	void Shoot() {

		Debug.Log (_Firepoint.rotation + "");

		Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);

		CreateBullet ();

		Vector2 firePP = new Vector2 (_Firepoint.position.x, _Firepoint.position.y);

		RaycastHit2D hit = Physics2D.Raycast (firePP, mousePosition, 100, hitWhat);

		Debug.DrawLine (firePP, mousePosition);
	}

	void CreateBullet() {

		GameObject temp = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;

	}

	IEnumerator reload() {
		yield return new WaitForSeconds (rateOfFire);
		canFire = true;
	}
}

//if(Input.GetMouseButtonDown(0)){
//	Debug.Log ("Pressed left click.");
//	canFire = false;
//	StartCoroutine ("reload");
//	GameObject temp = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;
//	temp.GetComponent<Rigidbody2D> ().AddForce (Vector3.right * 1000);
//	AudioSource.PlayClipAtPoint (yo, transform.position);
//}