using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{   
    private Transform target;
    private SmoothFollowTarget smoothFollowTarget;
    private SmoothLookAtTarget smoothLookAtTarget;

    private void Awake()
    {
        smoothFollowTarget = GetComponent<SmoothFollowTarget>();
        smoothLookAtTarget = GetComponent<SmoothLookAtTarget>();
    }

    private void OnEnable()
    {
        Rock.RockBornEve += RockBorn;
    }
    private void OnDisable()
    {
        Rock.RockBornEve += RockBorn;
    }

    private void RockBorn(Rock rock)
    {        
        target = rock.transform;
        smoothFollowTarget.FollowOn(target.transform);
        smoothLookAtTarget.LookAtOn(target.transform);
    }   
}
