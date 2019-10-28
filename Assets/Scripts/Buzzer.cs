using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzzer : MonoBehaviour
{
    private void OnEnable()
    {
        Timer.OnTimerStarted += PlayStartBuzzer;
        Timer.OnTimerEnded += PlayEndBuzzer;
    }

    private void OnDisable()
    {
        Timer.OnTimerStarted -= PlayStartBuzzer;
        Timer.OnTimerEnded -= PlayEndBuzzer;
    }

    void PlayStartBuzzer()
    {
        Debug.Log("[BUZZER] : play start buzzer!");
    }

    void PlayEndBuzzer()
    {
        Debug.Log("[BUZZER] : play end buzzer!");
    }
}
