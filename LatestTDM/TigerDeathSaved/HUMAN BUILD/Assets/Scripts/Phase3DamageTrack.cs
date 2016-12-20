using UnityEngine;
using System.Collections;

public class Phase3DamageTrack : MonoBehaviour
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

		SpriteRenderer renderer = GetComponent < SpriteRenderer >();

		renderer.color = new Color (1f, 0f, 0f, 1f);

		GameScore--;
		if (GameScore >= 1000)
		{

			Destroy(GameObject.FindGameObjectWithTag("ScoreHolder"));

		}

		scoreUITextGO.GetComponent<EndgameTrack>().addScore(50);

	}

	void OnTriggerExit2D()
	{
		SpriteRenderer renderer = GetComponent < SpriteRenderer >();

		renderer.color = new Color (1f, 1f, 1f, 1f);
	}
		
	void Die()
	{
		Destroy(gameObject);
	}
}
