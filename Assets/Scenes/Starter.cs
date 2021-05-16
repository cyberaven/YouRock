using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private GameCore gameCore;

    private void OnEnable()
    {
        StartGameCoreButton.StartGameCoreButtonClkEve += StartGameCoreButtonClk;
    }
    private void OnDisable()
    {
        StartGameCoreButton.StartGameCoreButtonClkEve -= StartGameCoreButtonClk;
    }

    private void StartGameCoreButtonClk()
    {
        StartGameCoreButton.StartGameCoreButtonClkEve -= StartGameCoreButtonClk;
        gameCore = Instantiate(gameCore);
    }
}
