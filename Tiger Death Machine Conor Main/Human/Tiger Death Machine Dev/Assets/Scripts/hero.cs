using UnityEngine;
using System.Collections;

public class hero : MonoBehaviour {

	public static Vector2 heroPos; //static- we wantthis variable to be available anywhere in the game, and the object needs to utilize it
	//Vector2: 2 variables: x and y

	// Use this for initialization
	void Start () {
		heroPos = GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
