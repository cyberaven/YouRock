using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RockRotater : MonoBehaviour
{
    private Rigidbody rigidbody;
    private GameObject steeringWheel;
    private bool rotateEnable = false;
    private float rotationSpeed = 10f;

    public void Init(Rigidbody rigidbody, GameObject steeringWheel)
    {
        this.rigidbody = rigidbody;
        this.steeringWheel = steeringWheel;
    }

    public void RotateOn()
    {
        rotateEnable = true;
    }

    public void RotateOff()
    {
        rotateEnable = false;
    }

    private void Update()
    {
        if(rotateEnable)
        {            
            
        }
    }
}