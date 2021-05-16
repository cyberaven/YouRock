using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartGameCoreButton : MonoBehaviour, IPointerClickHandler
{
    public delegate void StartGameCoreButtonClkDel();
    public static event StartGameCoreButtonClkDel StartGameCoreButtonClkEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        StartGameCoreButtonClkEve?.Invoke();
    }
}
