using UnityEngine;
using System.Collections;

public class objectPull : MonoBehaviour {

//public Vector2 objectPos; //capture position of the object
	public string objectStatus = "idle"; //we need to determine if the object is not being moved or if it is and therefore under ur control
	//when in ur control, idle status will change to hover
	public int zRot = 0;
	public float xVel = 0; //determines speed
	public float yVel = 0; //number is negative if moving r>l, positive if moving l>r
	public GameObject sparkle;
	public GameObject explosion;
	private GameObject heroGO;
	private Vector2 targetPos;

	// Use this for initialization
	void Start () {
	//	objectPos = GetComponent<Transform> ().position;
		sparkle.GetComponent<ParticleSystem> ().Stop();
		heroGO = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if ( Vector2.Distance(transform.position, targetPos) < 2 && 
			(objectStatus!="hover")){
			xVel = 0;
			yVel = 0;
			objectStatus = "hover";
			Instantiate (explosion, transform.position, transform.rotation);
			//instantiate explode prefab at transform.position
			Destroy (gameObject);
			//Destroy gameObject
		}

		transform.Rotate (0, 0, zRot);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (xVel, yVel);
	
	}

	void OnMouseDown() {
		if (objectStatus != "hover") {

			targetPos = new Vector2 (heroGO.transform.position.x, heroGO.transform.position.y);
			xVel = (transform.position.x - heroGO.transform.position.x + 0.8f) *-2f;
			yVel = (transform.position.y - heroGO.transform.position.y) *-2f;
			zRot = 15;

			sparkle.GetComponent<ParticleSystem> ().Play ();
		} else {
			yVel = 0;
			xVel = 15;
			zRot = -3;
		}
	}
}
