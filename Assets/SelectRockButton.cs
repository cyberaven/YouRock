using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SelectRockButton: MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int rockId = 0;

    public delegate void SelectRockButtonDel(int id);
    public static event SelectRockButtonDel SelectRockButtonEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectRockButtonEve?.Invoke(rockId);
    }
}
