using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public GameObject Portal;

	void OnTriggerEnter2D( Collider2D otherThing){
		if (otherThing.CompareTag ("Player")) {
			Debug.Log ("ENTERED WARP ZONE");
			otherThing.transform.position = Portal.transform.position;
		}
	}
}