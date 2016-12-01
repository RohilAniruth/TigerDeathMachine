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
        scoreText.text = "Dmg" + score;

    }


    void update()
    {
        if (restart)

        {
            if (Input.GetKeyDown (KeyCode.R))

            {
                SceneManager.LoadScene("TigerDeathBuild");

            }
        }
    }

    public void addScore(int pointsToAdd)
    {
        score += pointsToAdd;
        scoreText.text = "Dmg" + score;

        // GetComponent<AudioSource>().Play();

        if (score >= 3000)
        {
            //kill tiger
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Debug.Log("HIT");


        }
    }

        public void GameOver()
    {


        gameOverText.text = "You Lose";
        gameOver = true;
        
      
    }
    }



