using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

    public GameObject bulletPrefab;

   public float fireDelay = 0.25f;
   float cooldownTimer = 0;

   void Update()
   {
       cooldownTimer -= Time.deltaTime;
	
       if ( Input.GetButton("Fire1") && cooldownTimer <= 0)

        {

            cooldownTimer = fireDelay;
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

	}

	
	}