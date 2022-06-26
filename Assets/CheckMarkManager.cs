using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckMarkManager : MonoBehaviour
{
    public bool normal, siemprePegado, follow, corner, giratorio, scale, offscreenX, movingX, manyX, glitch, dontEraseMe;

    Toggle checkmark;

    private void Start()
    {
        checkmark = GetComponent<Toggle>();
    }
    public void Change()
    {
        if (normal) 
        {
            PopManager.instancia.normal = checkmark.isOn;
        }
        else if (scale)
        {
            PopManager.instancia.scale = checkmark.isOn;
        }
        else if (follow)
        {
            PopManager.instancia.follow = checkmark.isOn;
        }
        else if (siemprePegado)
        {
            PopManager.instancia.siemprePegado = checkmark.isOn;
        }
        else if (corner)
        {
            PopManager.instancia.corner = checkmark.isOn;
        }
        else if (giratorio)
        {
            PopManager.instancia.giratorio = checkmark.isOn;
        }
        else if (manyX)
        {
            PopManager.instancia.manyX = checkmark.isOn;
        }
    }
}
