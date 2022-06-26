using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabBarButtons : MonoBehaviour
{
    [SerializeField] Sprite tabPressed, tabNotPressed;
    [SerializeField] Image webTab, firewallTab;
    [HideInInspector] public bool firewall;
    public void TabButtons()
    {
        if (firewall)
        {
            webTab.sprite = tabNotPressed;
            firewallTab.sprite = tabPressed;
        }
        else
        {
            webTab.sprite = tabPressed;
            firewallTab.sprite = tabNotPressed;
        }
    }
}
