using UnityEngine;
using System.Collections;

public class icephase1 : MonoBehaviour
{

	GameObject scoreUITextGO;


	int GameScore = 0;

	void Start()
	{
		scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreHolder2");
		print(scoreUITextGO);

	}


	void OnTriggerEnter2D()
	{
		Debug.Log("Trigger!");

		GameScore--;
		if (GameScore >= 10000)
		{

			Destroy(GameObject.FindGameObjectWithTag("ScoreHolder2"));



		}



		scoreUITextGO.GetComponent<icephase2load>().addScore(50);

	}

	void Die()
	{
		Destroy(gameObject);
	}
}
