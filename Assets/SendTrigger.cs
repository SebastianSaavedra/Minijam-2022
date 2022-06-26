using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendTrigger : MonoBehaviour
{
    public void Send() 
    {
        PopManager.TriggerEvent("Thanks");
    }
}
