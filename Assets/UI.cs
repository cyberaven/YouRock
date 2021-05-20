using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject selectLevelPanel;
    private Camera mainCamera;
    private Canvas canvas;

    private void OnEnable()
    {
        StartLevelButton.StartLevelButtonEve += StartLevelButtonClk;
    }
    private void OnDisable()
    {
        StartLevelButton.StartLevelButtonEve -= StartLevelButtonClk;
    }

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        mainCamera = Camera.main;

        canvas.worldCamera = mainCamera;
    }

    private void StartLevelButtonClk(int id)
    {
        selectLevelPanel.SetActive(false);
    }
}
