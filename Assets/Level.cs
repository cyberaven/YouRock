using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int id = 0;
    [SerializeField] private RockRespawnPoint rockRespawnPoint;

    private Rock rock;

    public int Id { get => id; set => id = value; }

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
            throw new Exception("Не буду работать, камень дай!");
        }

        StartLevel();
    }

    private void StartLevel()
    {
        PutRockOnStartPos();
    }

    private void PutRockOnStartPos()
    {
        rock.transform.position = rockRespawnPoint.transform.position;
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
