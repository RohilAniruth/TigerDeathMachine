using UnityEngine;
using System.Collections;

public class IceDamageonCol : MonoBehaviour
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

		GameObject b = GameObject.FindGameObjectWithTag("Bunny");

		SpriteRenderer renderer = b.GetComponent<SpriteRenderer>();

			renderer.color = new Color (1f, 0f, 0f, 1f);

		GameScore--;
		if (GameScore >= 1000)
		{

			Destroy(GameObject.FindGameObjectWithTag("ScoreHolder"));

		}

		scoreUITextGO.GetComponent<IceDamageTrack>().addScore(50);

	}

	void OnTriggerExit2D()
	{
		GameObject b = GameObject.FindGameObjectWithTag("Bunny");

		SpriteRenderer renderer = b.GetComponent<SpriteRenderer>();

		renderer.color = new Color (1f, 1f, 1f, 1f);
	}




	void Die()
	{
		Destroy(gameObject);
	}
}
