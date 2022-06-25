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
    UnityAction listener1, listener2,listener3;
    [SerializeField] int worldSi, worldNo;
    [SerializeField] GameObject world;
    public static bool cor;
    void Start()
    {
        listener1 = new UnityAction(Si);
        listener2 = new UnityAction(No);
        listener2 = new UnityAction(Castigo);
        PopManager.StartListening("Si", Si);
        PopManager.StartListening("No", No);
        PopManager.StartListening("Castigo", Castigo);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Si()
    {
        worldSi += 1;
            StartCoroutine(worldSearchMePop());
    }
    void No()
    {
        worldNo += 1;
        if (worldNo >= 5)
        {
            StartCoroutine(worldSearchMePop());
        }
    }

    void Castigo() 
    {
        Debug.Log("Castigo");
    }
    IEnumerator worldSearchMePop()
    {
        world.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        world.SetActive(false);
        cor = true;
        yield break;
    }

    #region event
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
    #endregion
}
