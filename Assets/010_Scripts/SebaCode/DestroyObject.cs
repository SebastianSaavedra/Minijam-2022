using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
   public void Destroy() 
    {
        PopManager.instancia.ram += 0.1f;
        if (PopManager.instancia.ram >= 4) 
        {
            PopManager.instancia.ram = 4;
        }
        Destroy(gameObject);
    }
}
