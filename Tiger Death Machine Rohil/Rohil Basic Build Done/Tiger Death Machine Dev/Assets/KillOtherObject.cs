using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour
{

    void OnTriggerExit(Collider otherObject)
    {
        otherObject.transform.position = otherObject.transform.position + Vector3.up * 40;
        otherObject.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Debug.Log("thing moving out of the box");
    }

}