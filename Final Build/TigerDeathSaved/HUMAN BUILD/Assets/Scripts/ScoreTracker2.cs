using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreTracker2 : MonoBehaviour
{

    private int score = 0;
    Text scoreText;


    public GUIText gameOverText;

    private bool gameOver;
    public bool restart; 

    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "Your Damage  " + score;

    }



    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Your Damage  " + score;

        // GetComponent<AudioSource>().Play();

        if (score >= 10000)
        {
			GameObject t = GameObject.FindGameObjectWithTag("Player");
			print("should be tiger: " + t);
			Destroy(GameObject.FindGameObjectWithTag("Player"));
			Debug.Log("HIT");

			Application.LoadLevel ("HubWorld");


        }
    }


    }



