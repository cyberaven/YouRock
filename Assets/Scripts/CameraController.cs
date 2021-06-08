//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    [Range(1f,1000f)] public float laziness = 10f;
    public bool lookAtTarget = true;
    public bool takeOffsetFromInitialPos = true;
    public Vector3 generalOffset;
    Vector3 whereCameraShouldBe;
    bool warningAlreadyShown = false;

    private void Start() {
        if (takeOffsetFromInitialPos && target != null) generalOffset = transform.position - target.position;
    }

    void FixedUpdate()
    {        
    //    Debug.Log("Camera rotation: " + transform.rotation);
    //    Debug.Log("Camera rotation: " + transform.rotation.eulerAngles);
    //    Debug.Log("Camera rotation: " + transform.rotation.y);
        
    //    Quaternion rotation = transform.rotation;        
    //    if(transform.rotation.eulerAngles.y > 30 && transform.rotation.eulerAngles.y < 90)
    //    {
    //        generalOffset = new Vector3(-10, 3, 0);
    //    }
    //    if (transform.rotation.eulerAngles.y < 30 && transform.rotation.eulerAngles.y > 90)
    //    {
    //        generalOffset = new Vector3(0, 3, -10);
    //    }
        if (target != null) {
            whereCameraShouldBe = target.position + generalOffset;
            transform.position = Vector3.Lerp(transform.position, whereCameraShouldBe, 1 / laziness);

            if (lookAtTarget) transform.LookAt(target);
        } else {
            if (!warningAlreadyShown) {
                Debug.Log("Warning: You should specify a target in the simpleCamFollow script.", gameObject);
                warningAlreadyShown = true;
            }
        }
    }
}
