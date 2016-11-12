using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IceCreamController : MonoBehaviour
{
    public static float speed = 0f;
    public static float idleSpeed = 0f;
    public static float moveSpeed = 6f;


    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.A))
        {
            MoveIce(Vector3.left);
            //transform.position += new Vector3.left.normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.D))
        {
            MoveIce(Vector3.right);
            //transform.position += new Vector3.right.normalized * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.W))
        {
            MoveIce(Vector3.up);
            //transform.position += new Vector3.up.normalized * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow) ||
               Input.GetKey(KeyCode.S))
        {
            MoveIce(Vector3.down);
            //transform.position += new Vector3.down.normalized * speed * Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("TDM");
        }

        //If no longer moving
        if (Input.GetKeyUp(KeyCode.UpArrow) ||
              Input.GetKeyUp(KeyCode.DownArrow) ||
              Input.GetKeyUp(KeyCode.LeftArrow) ||
              Input.GetKeyUp(KeyCode.RightArrow) ||
              Input.GetKeyUp(KeyCode.W) ||
              Input.GetKeyUp(KeyCode.A) ||
              Input.GetKeyUp(KeyCode.S) ||
              Input.GetKeyUp(KeyCode.D))
        {
            speed = idleSpeed;
        }


        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0)

        {

            cooldownTimer = fireDelay;
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }


    }

    void MoveIce(Vector3 dir)
    {
        speed = moveSpeed;
        transform.position += dir.normalized * speed * Time.deltaTime;
        //transform.position += new Vector3.u

        //transform.position = transform.position + new Vector3.dir.normalized * speed * Time.deltaTime;
    }
}