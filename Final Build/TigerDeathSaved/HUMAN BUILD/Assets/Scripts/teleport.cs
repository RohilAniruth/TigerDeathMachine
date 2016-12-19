using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public GameObject Portal;


	void OnTriggerEnter2D( Collider2D otherThing){ 
		if (otherThing.CompareTag ("Player")) { 
			//if the player enters this trigggggger 
			if (otherThing.GetComponent<IceCreamController> ().warping == false) {
				// and the player hasn't just warped
				otherThing.GetComponent<IceCreamController> ().warping = true; //say the player just warppped
				otherThing.transform.position = Portal.transform.position; 
				// move the player to the target portal (set in the unity editor)
			} else {
				//if the player entered the trigger, and the player has just warped
				otherThing.GetComponent<IceCreamController> ().warping = false;
				// setup the player to be able to warp the next time they enter a trigger
			}
		}
	}
}