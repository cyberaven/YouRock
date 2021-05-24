using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotater : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MainCamera")
        {
            Debug.Log(other.gameObject.tag);
            other.transform.forward = gameObject.transform.forward;
        }
    }
}
