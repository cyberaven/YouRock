using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockControll : MonoBehaviour
{
    [SerializeField] private float rotateForce = 1f;
    [SerializeField] private float jumpForce = 1f;
    [SerializeField] private GameObject steeringWheel;
    private Rigidbody rigidbody;

    private void Awake()
    {
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

    private void UserPushKey(KeyCode keyCode)
    {
        if (keyCode == KeyCode.RightArrow)
        {
            steeringWheel.transform.Rotate(Vector3.up, 15);            
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            steeringWheel.transform.Rotate(Vector3.up, -15);           
        }
    }   
}
