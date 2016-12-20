using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartBoss2 : MonoBehaviour {

	// Use this for initialization


	void OnTriggerEnter2D ()
	{
		Application.LoadLevel ("ICE");
	}

}

