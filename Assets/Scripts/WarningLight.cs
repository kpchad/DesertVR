using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningLight : MonoBehaviour
{
    private void OnEnable()
    {
        Timer.OnHalfTime += BlinkLight;
    }

    private void OnDisable()
    {
        Timer.OnHalfTime -= BlinkLight;
    }

    void BlinkLight()
    {
        Debug.Log("[WARNING LIGHT] : It's half-time, blinking the warning light!");
    }
}
