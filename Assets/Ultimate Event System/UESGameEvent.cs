using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Ultimate Event System/GameEvent")]
public class UESGameEvent : ScriptableObject
{
    public List<UESGameEventListener> listeners = new List<UESGameEventListener>();

    public void Raise(Component sender, object coinData)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(sender, coinData);
        }

    }
    
    public void RegisterListener(UESGameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(UESGameEventListener listener)
    {
        listeners.Remove(listener);
    }


}