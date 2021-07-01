using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class RockControll : MonoBehaviour
{
    [SerializeField] private float forwardPushForce = 10f;
    [SerializeField] private float backPushForce = 10f;
    [SerializeField] private float rightPushForce = 10f;
    [SerializeField] private float leftPushForce = 10f;
    [SerializeField] private GameObject steeringWheel;
    private RockRotater rockRotater;
    
    private Rigidbody rigidbody;
    private bool onGround = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        steeringWheel = Camera.main.gameObject;
        rockRotater = GetComponent<RockRotater>();
        rockRotater.Init(rigidbody, steeringWheel);
    }    

    private void OnEnable()
    {
        ThrottleButton.ThrottleButtonClkEve += ThrottleButtonClk;
        ThrottleButton.ThrottleButtonDownEve += ThrottleButtonDown;
        ThrottleButton.ThrottleButtonUpEve += ThrottleButtonUp;
        UserInput.UserPushKeyEve += UserPushKey;
    }

    

    private void OnDisable()
    {
        ThrottleButton.ThrottleButtonClkEve -= ThrottleButtonClk;
        ThrottleButton.ThrottleButtonDownEve -= ThrottleButtonDown;
        ThrottleButton.ThrottleButtonUpEve -= ThrottleButtonUp;
        UserInput.UserPushKeyEve -= UserPushKey;
    }

    private void ThrottleButtonClk()
    {        
    }
    private void ThrottleButtonUp()
    {
        
    }

    private void ThrottleButtonDown()
    {
        rigidbody.AddForce(steeringWheel.transform.forward * forwardPushForce, ForceMode.Impulse);
    }

    private void UserPushKey(KeyCode keyCode)
    {        
        if (keyCode == KeyCode.UpArrow)
        {
            rigidbody.AddForce(steeringWheel.transform.forward * forwardPushForce, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.DownArrow)
        {
            rigidbody.AddForce(-steeringWheel.transform.forward * backPushForce, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.RightArrow)
        {
            rigidbody.AddForce(steeringWheel.transform.right * rightPushForce, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            rigidbody.AddForce(-steeringWheel.transform.right * leftPushForce, ForceMode.Impulse);
        }        
    }   
}
