using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private Rock rock;
    private Rigidbody rockRigidbody;
    private bool followEnable = false;
    private Vector3 offsetPoint = new Vector3(0f, 4.5f, -5f);
    private CameraController cameraController;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ChangeOffSetForCam")
        {
            Vector3 newOffset = other.gameObject.transform.GetComponent<ChangeOffSetForCam>().camOffset;
            ChangeOffSetForCam(newOffset);
        }
    }

    private void ChangeOffSetForCam(Vector3 newOffset)
    {
        cameraController.generalOffset = newOffset;
    }

    private void Awake()
    {
        cameraController  = GetComponent<CameraController>();        
    }

    private void OnEnable()
    {
        Rock.RockBornEve += RockBorn;
    }
    private void OnDisable()
    {
        Rock.RockBornEve += RockBorn;
    }

    private void RockBorn(Rock rock)
    {
        cameraController.target = rock.transform;   
    }
}
