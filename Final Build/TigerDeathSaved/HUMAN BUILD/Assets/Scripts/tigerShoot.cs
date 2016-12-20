using UnityEngine;

using System.Collections;



public class tigerShoot : MonoBehaviour
{





    public GameObject enemyProjectile;

    public float bulletSpeed = 10000;

    private float timer = 1f;

    private float secondsBetweenShots = 1;



    void Update()
    {



        Attack();

    }



    private void Attack()
    {

        timer -= Time.deltaTime;



        if (timer <= 0)
        {



            GameObject temp = Instantiate(enemyProjectile, transform.position, transform.rotation) as GameObject;

            temp.GetComponent<Rigidbody2D>().AddForce(Vector2.left * bulletSpeed);

            Debug.Log("Working shooting");

            timer = secondsBetweenShots;

        }



    }

}
