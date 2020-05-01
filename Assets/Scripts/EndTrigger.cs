using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    void OnTriggerEnter()
    {
        GameObject canvasGroup = GameObject.Find("CanvasGroup");
        Timer timer = canvasGroup.GetComponent<Timer>();
        timer.win.gameObject.SetActive(true);
    }
}
