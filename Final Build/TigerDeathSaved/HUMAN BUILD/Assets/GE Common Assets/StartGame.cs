using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {


	void start () {
		
	
	}


	void update() {


		if (Input.GetMouseButton (0)) {

			Application.LoadLevel ("HubWorld");
		}
	}
}