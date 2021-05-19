using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private LevelsContainer levels;
    [SerializeField] private GameCore gameCore;

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
        levels = Instantiate(levels, transform);
        gameCore = Instantiate(gameCore, transform);
    }

    private void StartLevelButtonClk(int levelId)
    {
        Level level = Instantiate(levels.GetLevel(levelId));
        Rock rock = Instantiate(gameCore.Rock);
        level.Init(rock);
    }
}
