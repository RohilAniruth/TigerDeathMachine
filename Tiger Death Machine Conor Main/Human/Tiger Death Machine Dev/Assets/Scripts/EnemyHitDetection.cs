using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        GameObject TDM = GameObject.Find("ScoreHolder");
        TDM.GetComponent<ScoreTracker>().addScore(1);

        Destroy(gameObject);


    }
}