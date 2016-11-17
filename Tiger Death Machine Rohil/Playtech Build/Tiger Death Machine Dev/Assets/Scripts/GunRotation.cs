using UnityEngine;
using System.Collections;

public class GunRotation : MonoBehaviour {

	public Transform hitPoint;

	public bool direction; //right is true, left is false

	public IceCreamController p_Script;

//	public Camera cam;

	public int posOffset;

	Transform playerGraphics;

	void Start () {

		direction = true;

	}

	void Awake () {
		
		playerGraphics = transform.FindChild ("firecracker");

	}

	void Update () {



		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5f;

		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);

		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		float angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;

		//Debug.Log(angle + "");

		if (direction == true) {

			posOffset = 0;

		}

		if (direction == false) {

			posOffset = 110;

		}

		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle + posOffset)); //rotating

		if (angle > 0f && angle < 100f || angle < 0f && angle > -90f) {		//angles on the "right" side of the 360 degrees

			if (direction == false) {

				direction = true;

				Flip ();
			}
		}

		if (angle > 100f && angle < 180f || angle < -90f && angle > -180f)
		
			if (direction == true) {

				direction = false;

				Flip ();
			}
		}


		void Flip() {

			if (direction == false && p_Script._Direction == true || direction == true && p_Script._Direction == false)

			{ p_Script.Flipp(); }

			hitPoint.Rotate(Vector3.forward * 180); //might change

			Vector3 theScale = playerGraphics.localScale;

				theScale.x *= -1;

			playerGraphics.localScale = theScale;

		}

	}






//	public int rotationOffset = 0;
//	
//	// Update is called once per frame
//	void Update () {
//		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;			//subtracting the position of the player from the mouse position
//		difference.Normalize (); 				//normalizing the vector, meaning the sum of the vector will be equal to 1
//
//		float rotz = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;		//making a variable to store it in, then finding the angle from x and y axis, then converting it to degrees
//		transform.rotation = Quaternion.Euler (0f, 0f, rotz + rotationOffset);
//	}
//}
