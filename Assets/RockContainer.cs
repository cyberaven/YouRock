using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockContainer : MonoBehaviour
{
    [SerializeField] private List<Rock> rocks;

    public Rock GetRock(int id)
    {
        return rocks[id];       
    }
}
