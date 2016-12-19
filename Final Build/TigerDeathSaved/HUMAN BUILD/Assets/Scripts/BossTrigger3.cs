using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossTrigger3 : MonoBehaviour {

	// Use this for initialization


	void OnTriggerEnter2D ()
	{
		Application.LoadLevel ("TDMPHASE1");
	}

}

