using System;
using UnityEngine;

public class SmoothLookAtTarget : MonoBehaviour
{
    private Transform target;
    [SerializeField] private bool lookAtEnable = false;
    private float rotateSpeed = 1f;

    public void LookAtOn(Transform transform)
    {
        target = transform;
        lookAtEnable = true;
    }
    private void Update()
    {
        if (lookAtEnable)
        {
           transform.LookAt(target);            
        }
    }
}