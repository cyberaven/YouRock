using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
        camera.transform.SetParent(gameObject.transform);        
    }
}
