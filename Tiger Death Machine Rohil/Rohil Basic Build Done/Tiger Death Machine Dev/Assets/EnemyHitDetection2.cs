using UnityEngine;
using System.Collections;

public class EnemyHitDetection2 : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        GameObject Player = GameObject.Find("ScoreHolder2");
        Player.GetComponent<ScoreTracker>().addScore(1);

        Destroy(gameObject);


    }
}
