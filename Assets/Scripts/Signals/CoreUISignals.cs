using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoreUISignals : MonoBehaviour
{
    public UnityAction<UIPanelTypes, int> onOpenPanel = delegate { }; 
    public UnityAction<int> onClosePanel = delegate { }; 
    public UnityAction onCloseAllPanel = delegate { }; 

    public static CoreUISignals Instance;

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
