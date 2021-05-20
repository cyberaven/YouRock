using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public delegate void UserPushKeyDel(KeyCode keyCode);
    public static event UserPushKeyDel UserPushKeyEve;

    public delegate void UserUpKeyDel(KeyCode keyCode);
    public static event UserUpKeyDel UserUpKeyEve;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            UserPushKeyEve?.Invoke(KeyCode.RightArrow);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            UserUpKeyEve?.Invoke(KeyCode.RightArrow);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            UserPushKeyEve?.Invoke(KeyCode.LeftArrow);
        }  
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            UserUpKeyEve?.Invoke(KeyCode.LeftArrow);
        }

    }
}
