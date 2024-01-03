using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoreGameSignals : MonoBehaviour
{
    public UnityAction<byte> onLevelInitialize = delegate { };
    public UnityAction onClearActiveLevel = delegate { };
    public UnityAction onNextLevel = delegate { };
    public UnityAction onRestartLevel = delegate { };
    public UnityAction onReset = delegate { };
    public Func<byte> onGetLevelValue = delegate { return 0; };
    

    public static CoreGameSignals Instance;

    private void Awake() 
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        Instance = this;
    }
}
