using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    [Range(1f,100f)] public float laziness = 10f;
    public bool lookAtTarget = true;
    public bool takeOffsetFromInitialPos = true;
    public Vector3 generalOffset;
    public Vector3 whereCameraShouldBe;
    public float distanceToObj = 10f;
    public bool warningAlreadyShown = false;

    private void Start() {
        if (takeOffsetFromInitialPos && target != null) generalOffset = transform.position - target.position;
    }

    void FixedUpdate()
    {            
        if (target != null) 
        {
            Vector3 x = target.position + new Vector3(0, 3, 0);

            if(Vector3.Distance(x, transform.position) > distanceToObj)
            {
                transform.position = Vector3.Lerp(transform.position, x, 1 / laziness);                
            }
            
            //whereCameraShouldBe = target.position + generalOffset;
            //transform.position = Vector3.Lerp(transform.position, whereCameraShouldBe, 1 / laziness);

            if (lookAtTarget) transform.LookAt(target);
        } else {
            if (!warningAlreadyShown) {
                Debug.Log("Warning: You should specify a target in the simpleCamFollow script.", gameObject);
                warningAlreadyShown = true;
            }
        }
    }
}
