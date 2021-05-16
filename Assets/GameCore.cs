using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    [SerializeField] private Vector3 startRockPos = Vector3.zero;
    [SerializeField] private Rock rock;


    private void Start()
    {
        rock = Instantiate(rock);
        rock.transform.position = startRockPos;        
    }
}
