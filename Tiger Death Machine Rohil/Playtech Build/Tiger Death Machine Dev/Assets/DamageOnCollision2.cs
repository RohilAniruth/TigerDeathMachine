using UnityEngine;
using System.Collections;

public class DamageOnCollision2 : MonoBehaviour
{

    GameObject scoreUITextGO;
    

    int GameScore = 1;

    void Start()
    {
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreHolder2");
        print(scoreUITextGO);

    }


    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        GameScore--;
        if (GameScore >= 1000)
        {

            Destroy(gameObject);



        }



        scoreUITextGO.GetComponent<ScoreTracker2>().addScore(10);

    }
    
    void Die()
    {
        Destroy(gameObject);
    }
}
