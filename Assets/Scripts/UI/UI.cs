using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject selectLevelPanel;
    [SerializeField] private GameObject cooldownPanel;
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

    private void StartLevelButtonClk()
    {
        selectLevelPanel.SetActive(false);
    }
}
