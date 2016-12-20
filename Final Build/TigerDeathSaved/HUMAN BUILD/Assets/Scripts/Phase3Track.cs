using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Phase3Track : MonoBehaviour
{
	private int score = 0;
	Text scoreText;


	// Use this for initialization
	void Start()
	{
		scoreText = GetComponent<Text>();
		scoreText.text = "BOSS  " + score;

	}

	public void addScore(int pointsToAdd)
	{
		score += pointsToAdd;
		scoreText.text = "BOSS  " + score;

		// GetComponent<AudioSource>().Play();

		if (score >= 2000) {
			//kill tiger
			GameObject t = GameObject.FindGameObjectWithTag("TDM");
			print("should be tiger: " + t);
			Destroy(GameObject.FindGameObjectWithTag("TDM"));
			Debug.Log("HIT");

			Application.LoadLevel ("TDMPHASE3");

		}


	}



}