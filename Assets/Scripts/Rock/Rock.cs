using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Camera camera;
    [SerializeField] private Transform cameraParent;
    private Rigidbody rigidbody;

    private void Awake()
    {
        camera = Camera.main;

        camera.transform.SetParent(cameraParent);
        rigidbody = GetComponent<Rigidbody>();
    }

    //private void Update()
    //{
    //    camera.transform.forward = rigidbody.velocity;
    //}
}
