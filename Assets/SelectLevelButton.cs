using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectLevelButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int levelId = 0;

    public delegate void SelectLevelButtonDel(int id);
    public static event SelectLevelButtonDel SelectLevelButtonEve;

    public void OnPointerClick(PointerEventData eventData)
    {
        SelectLevelButtonEve?.Invoke(levelId);
    }
}
