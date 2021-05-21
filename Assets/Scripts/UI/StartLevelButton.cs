using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartLevelButton : MonoBehaviour, IPointerClickHandler
{    
    public delegate void StartLevelButtonDel();
    public static event StartLevelButtonDel StartLevelButtonEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartLevelButtonEve?.Invoke();
    }
}
