using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsContainer : MonoBehaviour
{
    [SerializeField] private List<Level> levels;

    public Level GetLevel(int id)
    {
        foreach (Level level in levels)
        {
            if(level.Id == id)
            {
                return level;
            }
        }
        throw new System.Exception("No level witn id: " + id);
    }
}
