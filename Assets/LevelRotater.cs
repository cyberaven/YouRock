using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotater : MonoBehaviour
{
    private Level level;
    private Rock rock;
    private bool rotateEnable = false;
    private int rotateDirection = 1;
    [SerializeField] private int rotateSpeed = 20;

    private void OnEnable()
    {
        Level.LevelCreatedEve += LevelCreated;
        UserInput.UserPushKeyEve += UserPushKeyEve;
        UserInput.UserUpKeyEve += UserUpKeyEve;
    }
    private void OnDisable()
    {
        Level.LevelCreatedEve += LevelCreated;
        UserInput.UserPushKeyEve -= UserPushKeyEve;
        UserInput.UserUpKeyEve -= UserUpKeyEve;
    }
   
    
    private void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        if (rotateEnable == true)
        {
            level.transform.RotateAround(rock.transform.position, Camera.main.transform.forward, 1f * rotateDirection * Time.deltaTime * rotateSpeed);
        }
    }

    private void LevelCreated(Level level, Rock rock)
    {
        this.level = level;
        this.rock = rock;
    }

    private void UserPushKeyEve(KeyCode keyCode)
    {
        if (keyCode == KeyCode.RightArrow)
        {
            RotateOn(-1);
        }
        if (keyCode == KeyCode.LeftArrow)
        {
            RotateOn(1);
        }
    }
    private void UserUpKeyEve(KeyCode keyCode)
    {
        RotateOff();
    }

    private void RotateOn(int x)
    {
        rotateDirection = x;
        rotateEnable = true;       
    }
    private void RotateOff()
    {
        rotateEnable = false;
    }
}
