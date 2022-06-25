using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PreguntaWorld : MonoBehaviour
{
    UnityAction listener1, listener2;
    [SerializeField] GameObject parent;

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Si() 
    {
        PopManager.TriggerEvent("Si");
        Destroy(parent);
    }

    public void No() 
    {
        PopManager.TriggerEvent("No");
        Destroy(parent);
    }

}
