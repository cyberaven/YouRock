using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    public delegate void DeathColliderDel();
    public static event DeathColliderDel DeathColliderEve;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Rock")
        {
            Debug.Log("DeathColliderTouchRock");
            DeathColliderEve?.Invoke();
        }
    }
}
