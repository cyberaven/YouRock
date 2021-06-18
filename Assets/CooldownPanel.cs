using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownPanel : MonoBehaviour
{
    [SerializeField] private Text cooldownText;
    private int cooldownTime = 0;
    private int cooldownInterval = 1;
    private bool cooldownEnable = false;

    public void StartCooldown(int startTime)
    {
        cooldownTime = startTime;       
        StartCoroutine(TimerRoutine());
    }
    
    private IEnumerator TimerRoutine()
    {
        while (cooldownTime > 0)
        {
            ChangeText(cooldownTime);
            cooldownTime -= cooldownInterval;
            yield return new WaitForSeconds(1);
        }        
    }

    private void ChangeText(int x)
    {
        cooldownText.text = x + "";
    }
}
