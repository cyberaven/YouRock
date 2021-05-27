using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Camera camera;
    [SerializeField] private Transform cameraParent;
    private Rigidbody rigidbody;

    [SerializeField] private float rotateForce = 1f;

    private void Awake()
    {
        camera = Camera.main;

        camera.transform.SetParent(cameraParent);
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        UserInput.UserPushKeyEve += UserPushKey;
    }
    private void OnDisable()
    {
        UserInput.UserPushKeyEve -= UserPushKey;
    }
    private void Update()
    {        
        cameraParent.transform.forward = -rigidbody.velocity.normalized;
    }

    private void UserPushKey(KeyCode keyCode)
    {
        if(keyCode == KeyCode.RightArrow)
        {
            rigidbody.AddForce(camera.transform.right * rotateForce, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            rigidbody.AddForce(-camera.transform.right * rotateForce, ForceMode.Impulse);
        }
    }
}
