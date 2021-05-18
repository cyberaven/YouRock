using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private Camera mainCamera;
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        mainCamera = Camera.main;

        canvas.worldCamera = mainCamera;
    }    
}
