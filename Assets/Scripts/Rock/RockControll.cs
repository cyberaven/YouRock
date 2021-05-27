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
            rigidbody.AddForce(steeringWheel.transform.right * rotateForce, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            rigidbody.AddForce(-steeringWheel.transform.right * rotateForce, ForceMode.Impulse);
        }
    }
}
