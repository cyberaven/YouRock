using System;
using UnityEngine;

public class SmoothFollowTarget : MonoBehaviour
{
    private Transform target;
    [SerializeField] private bool followEnable = false;
    private float distanceTarget = 10f;
    private Vector3 offSet = new Vector3(0, 3, 0);
    private float moveSpeed = 1f;

    public void FollowOn(Transform transform)
    {
        target = transform;
        followEnable = true;        
    }
    private void FixedUpdate()
    {
        if(followEnable)
        {
            if (Vector3.Distance(transform.position, target.position) > distanceTarget)
            {
                Follow(target);
            }
        }
    }

    private void Follow(Transform target)
    {
        Vector3 followPoint = target.position + offSet;
        transform.position = Vector3.Lerp(transform.position, followPoint, moveSpeed * Time.deltaTime);
        
    }
}