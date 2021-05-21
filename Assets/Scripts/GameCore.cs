using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{  
    [SerializeField] private Rock rock;

    public Rock Rock { get => rock; set => rock = value; }
}
