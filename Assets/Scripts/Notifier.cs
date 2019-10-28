using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{

    private void OnEnable()
    {
        Timer.OnTimerEnded += ShowGameOverPopUp;
    }

    private void OnDisable()
    {
        Timer.OnTimerEnded -= ShowGameOverPopUp;
    }

    void ShowGameOverPopUp()
    {
        Debug.Log("[NOTIFIER] : show game over pop up!");
    }
}
