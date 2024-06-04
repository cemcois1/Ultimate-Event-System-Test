using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UESCustomUnityEvent:UnityEvent<Component, object>
{
}



public class UESGameEventListener:MonoBehaviour
{
    public UESGameEvent gameEvent;
    public UESCustomUnityEvent response;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }


    public void OnEventRaised(Component sender, object coinData)
    {
        response.Invoke(sender, coinData);
    }
}