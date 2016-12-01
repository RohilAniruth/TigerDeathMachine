using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour
{

    //	public GameObject bullet;
    private bool canFire = true;
    //	public AudioClip yo;

    public float shakeDuration = 0.1f;
    public float magnitude = 0.1f;

    public float rateOfFire = .4f;

    Vector3 initialL;
    Quaternion initialR;

    // Use this for initialization
    void Start()
    {

        initialL = transform.position;
        initialR = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canFire == true)
        {
            canFire = false;
            StartCoroutine("reload");
            //			GameObject temp = Instantiate (bullet, transform.position, bullet.transform.rotation) as GameObject;
          //  GetComponent<Rigidbody>().AddForce(Vector3.right * 1000);
            //			AudioSource.PlayClipAtPoint (yo, transform.position);
        }
    }

    IEnumerator reload()
    {
        yield return new WaitForSeconds(rateOfFire);
        canFire = true;

        float timeLeft = shakeDuration;
        while (timeLeft > 0)
        {
            transform.position = initialL + Random.insideUnitSphere * magnitude;
            timeLeft -= Time.deltaTime;
            yield return null;
        }

        transform.position = initialL;
        transform.rotation = initialR;
    }
}