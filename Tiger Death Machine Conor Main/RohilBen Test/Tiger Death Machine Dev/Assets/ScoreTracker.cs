using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{

    private int score = 0;
    Text scoreText;


    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "Dmg" + score;

    }

    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Dmg" + score;

       // GetComponent<AudioSource>().Play();

        if (score >= 1000) {
            //kill tiger
            Destroy(GameObject.FindGameObjectWithTag("TDM"));
            Debug.Log("HIT");
        }
    }



}