using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ThrottleButton : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    public delegate void ThrottleButtonClkDel();
    public static event ThrottleButtonClkDel ThrottleButtonClkEve;

    public delegate void ThrottleButtonDownDel();
    public static event ThrottleButtonDownDel ThrottleButtonDownEve;

    public delegate void ThrottleButtonUpDel();
    public static event ThrottleButtonUpDel ThrottleButtonUpEve;


    public void OnPointerClick(PointerEventData eventData)
    {
        ThrottleButtonClkEve?.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ThrottleButtonDownEve?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ThrottleButtonUpEve?.Invoke();
    }
}
