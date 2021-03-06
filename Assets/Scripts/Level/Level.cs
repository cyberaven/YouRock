using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int id = 0;
    [SerializeField] private Transform rockRespawnPoint;

    private Rock rock;

    public int Id { get => id; set => id = value; }

    public delegate void LevelCreatedDel(Level level, Rock rock);
    public static event LevelCreatedDel LevelCreatedEve;

    private void OnEnable()
    {
        DeathCollider.DeathColliderEve += DeathColliderEve;        
    }
    private void OnDisable()
    {
        DeathCollider.DeathColliderEve -= DeathColliderEve;       
    }   

    public void Init(Rock rock)
    {
        this.rock = rock;

        if(this.rock == null)
        {
            throw new Exception("?? ???? ????????, ?????? ???!");
        }

        LevelCreatedEve?.Invoke(this, rock);

        StartLevel();
    }

    private void StartLevel()
    {
        PutRockOnStartPos();
    }

    private void PutRockOnStartPos()
    {
        rock.PutOnStartPosition(rockRespawnPoint);             
    }

    private void DeathColliderEve()
    {
        RestartLevel();
    }

    private void RestartLevel()
    {
        StartLevel();
    }
}
