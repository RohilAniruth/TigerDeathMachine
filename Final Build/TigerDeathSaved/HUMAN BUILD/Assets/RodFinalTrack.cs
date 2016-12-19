using UnityEngine;
using System.Collections;

public class RodFinalTrack : MonoBehaviour
{

	GameObject scoreUITextGO;





	int GameScore = 0;

	void Start()
	{
		scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreHolder");

	}


	void OnTriggerEnter2D()
	{
		Debug.Log("Trigger!");

		GameScore--;
		if (GameScore >= 10000)
		{

			Destroy(GameObject.FindGameObjectWithTag("ScoreHolder"));

		}

		scoreUITextGO.GetComponent<RodBackToHub>().addScore(50);

	}





	void Die()
	{
		Destroy(gameObject);
	}
}
