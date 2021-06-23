using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rock : MonoBehaviour
{   
    private Rigidbody rigidbody;
      
    public delegate void RockBornDel(Rock rock);
    public static event RockBornDel RockBornEve;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();        
    }
    private void Start()
    {
        RockBornEve?.Invoke(this);
    }
    private void OnEnable()
    {       
        StartLevelButton.StartLevelButtonEve += StartLevelButtonClk;
    }
    private void OnDisable()
    {        
        StartLevelButton.StartLevelButtonEve -= StartLevelButtonClk;
    }
    private void Update()
    {
        Debug.Log(transform.position);
    }

    private void StartLevelButtonClk()
    {
        rigidbody.useGravity = true;       
    }
    
    internal void PutOnStartPosition(Transform rockRespawnPoint)
    {
        transform.position = rockRespawnPoint.transform.position; 
    }     
}
