using UnityEngine;
using System.Collections;

public class IceDamageonCol2 : MonoBehaviour
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
		if (GameScore >= 1000)
		{

			Destroy(GameObject.FindGameObjectWithTag("ScoreHolder"));

		}

		scoreUITextGO.GetComponent<IceDamageTrack2>().addScore(50);

	}





	void Die()
	{
		Destroy(gameObject);
	}
}
