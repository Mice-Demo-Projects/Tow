using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    #region Instance
    public static Vibration instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    void Vibrate()
    {
        if (SwitchHandler.instance.vibSwitchState == -1)
        {
            Handheld.Vibrate(); 
        }

    }
}
