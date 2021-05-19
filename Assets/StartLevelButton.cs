using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartLevelButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int levelId = 0;

    public delegate void StartLevelButtonDel(int id);
    public static event StartLevelButtonDel StartLevelButtonEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartLevelButtonEve?.Invoke(levelId);
    }
}
