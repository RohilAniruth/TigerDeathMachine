using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour
{


    public AudioSource audioSource;
    public AudioSource AudioClip;


    void OnTriggerEnter2D()
    {

        GetComponent<AudioSource>().Play();

    }
}