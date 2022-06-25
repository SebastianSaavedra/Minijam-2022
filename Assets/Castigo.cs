using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castigo : MonoBehaviour
{
   public void CastigoTrigger() 
    {
        PopManager.TriggerEvent("Castigo");
    }
}
