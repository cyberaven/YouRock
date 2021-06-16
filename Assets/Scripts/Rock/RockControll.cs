using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RockControll : MonoBehaviour
{
    [SerializeField] private float forwardPushForce = 10f;
    [SerializeField] private float backPushForce = 10f;
    [SerializeField] private float rightPushForce = 10f;
    [SerializeField] private float leftPushForce = 10f;    
    [SerializeField] private GameObject steeringWheel;
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        steeringWheel = Camera.main.gameObject;
    }    

    private void OnEnable()
    {
        UserInput.UserPushKeyEve += UserPushKey;
    }
    private void OnDisable()
    {
        UserInput.UserPushKeyEve -= UserPushKey;
    }

    private void UserPushKey(KeyCode keyCode)
    {
        Vector3 moveDirection = rigidbody.velocity.normalized;

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
