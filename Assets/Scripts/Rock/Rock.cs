using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rock : MonoBehaviour
{
    private Camera camera;
    [SerializeField] private Transform cameraParent;
    [SerializeField] private Transform cameraPoint;
    [SerializeField] private Rigidbody view;
    private Rigidbody rigidbody;

    [SerializeField] private float rotateForce = 1f;
    [SerializeField] private float pushForce = 2f;
    private bool moveEnable = false;

    private void Awake()
    {
        camera = Camera.main;
        camera.transform.SetParent(cameraParent);
        camera.transform.position = cameraPoint.position;

        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {       
        StartLevelButton.StartLevelButtonEve += StartLevelButtonClk;
    }
    private void OnDisable()
    {        
        StartLevelButton.StartLevelButtonEve -= StartLevelButtonClk;
    }

    private void StartLevelButtonClk()
    {
        moveEnable = true;
        Move();
    }
    
    internal void PutOnStartPosition(Transform rockRespawnPoint)
    {
        transform.position = rockRespawnPoint.transform.position;
        cameraParent.transform.forward = rockRespawnPoint.transform.forward;
        camera.transform.forward = rockRespawnPoint.transform.forward;
        view.GetComponent<Rigidbody>().useGravity = true;
    }

    private void Move()
    {
        if (moveEnable)
        {
            rigidbody.velocity = cameraParent.transform.forward.normalized * pushForce;            
        }
    }    
}
