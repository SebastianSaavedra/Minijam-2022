using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStrings : MonoBehaviour
{
    public bool first, second;
    [SerializeField] GameObject button;
    public void Check(string wich) 
    {
        if (wich == "first") 
        {
            first = true;
        }
        if (wich == "second")
        {
            second = true;
        }
        if (first && second) 
        {
            button.SetActive(true);
        }
    }
}
