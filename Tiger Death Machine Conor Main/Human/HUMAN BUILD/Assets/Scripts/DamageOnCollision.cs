using UnityEngine;
using System.Collections;

public class DamageOnCollision : MonoBehaviour
{

    GameObject scoreUITextGO;

    



    int GameScore = 1;

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

            Destroy(gameObject);
            
        }

        scoreUITextGO.GetComponent<ScoreTracker>().addScore(10);

    }





   void Die()
    {
        Destroy(gameObject);
   }
}
