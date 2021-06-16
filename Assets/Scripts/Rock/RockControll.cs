using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RockControll : MonoBehaviour
{
    [SerializeField] private float rotateForce = 1f;
    [SerializeField] private float jumpForce = 1f;
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
            rigidbody.AddForce(steeringWheel.transform.forward * 10f, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.DownArrow)
        {
            rigidbody.AddForce(-steeringWheel.transform.forward * 10f, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.RightArrow)
        {
            rigidbody.AddForce(steeringWheel.transform.right * 10f, ForceMode.Impulse);
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            rigidbody.AddForce(-steeringWheel.transform.right * 10f, ForceMode.Impulse);
        }
    }   
}
