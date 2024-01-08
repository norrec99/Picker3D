using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputSignals : MonoBehaviour
{
    public UnityAction onFirstTimeTouchTaken   = delegate { };
    public UnityAction onEnableInput  = delegate { };
    public UnityAction onDisableInput  = delegate { };
    public UnityAction onInputTaken  = delegate { };
    public UnityAction onInputReleased = delegate { };
    public UnityAction<HorizontalInputParams> onInputDragged = delegate { };


    public static InputSignals Instance;

    private void Awake() 
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
}
