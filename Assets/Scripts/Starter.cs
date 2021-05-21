using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private LevelsContainer levels;
    [SerializeField] private RockContainer rocks;
    [SerializeField] private GameCore gameCore;

    private Level level;
    private Rock rock;

    private void OnEnable()
    {
        SelectLevelButton.SelectLevelButtonEve += SelectLevelButtonClk;
        SelectRockButton.SelectRockButtonEve += SelectRockButtonClk;
        StartLevelButton.StartLevelButtonEve += StartLevelButtonClk;        
    }
    private void OnDisable()
    {
        SelectLevelButton.SelectLevelButtonEve -= SelectLevelButtonClk;
        SelectRockButton.SelectRockButtonEve -= SelectRockButtonClk;
        StartLevelButton.StartLevelButtonEve -= StartLevelButtonClk;        
    }   

    private void Awake()
    {
        levels = Instantiate(levels, transform);
        rocks = Instantiate(rocks, transform);
        gameCore = Instantiate(gameCore, transform);
    }
    private void SelectLevelButtonClk(int id)
    {
        if(level != null)
        {
            Destroy(level);            
        }

        level = Instantiate(levels.GetLevel(id));
    }
    private void SelectRockButtonClk(int id)
    {
        if(rock != null)
        {
            Destroy(rock);            
        }

        rock = Instantiate(rocks.GetRock(id));        
    }

    private void StartLevelButtonClk()
    {               
        level.Init(rock);
        rock.GetComponent<Rigidbody>().useGravity = true;
    }
}
