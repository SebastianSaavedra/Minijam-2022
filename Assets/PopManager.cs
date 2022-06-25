using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PopManager : MonoBehaviour
{
    public List<GameObject> pops;
    private Dictionary<string, UnityEvent> eventdic;
    private static PopManager popManager;
    public static PopManager instancia
    {
        get
        {
            if (!popManager)
            {
                popManager = FindObjectOfType(typeof(PopManager)) as PopManager;
                if (!popManager)
                {
                    Debug.LogError("No tenemos CaracolManager");
                }
                else
                {
                    popManager.Init();
                }
            }
            return popManager;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        if (eventdic == null)
        {
            eventdic = new Dictionary<string, UnityEvent>();
            Debug.Log("Event added");
        }
    }
    public static void StartListening(string eventName, UnityAction listener)
    {
        UnityEvent thisEvent = null;
        if (instancia.eventdic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            instancia.eventdic.Add(eventName, thisEvent);
        }
    }

    public static void StopLIstening(string eventName, UnityAction listener)
    {
        if (instancia == null) return;
        UnityEvent thisEvent = null;
        if (instancia.eventdic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    public static void TriggerEvent(string eventName)
    {
        UnityEvent thisEvent = null;
        if (instancia.eventdic.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }
}
