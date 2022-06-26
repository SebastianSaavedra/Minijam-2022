using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    [SerializeField] List<Toggle> checkmarks;
    [SerializeField] Slider consume;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetSliderValue();
        if (consume.value > 0.9f) 
        {
            foreach (Toggle checkmark in checkmarks) 
            {
                if (!checkmark.isOn) 
                {
                    checkmark.interactable = false;
                }
            }
        }
        else 
        {
            foreach (Toggle checkmark in checkmarks)
            {
                if (!checkmark.isOn)
                {
                    checkmark.interactable = true;
                }
            }
        }
    }

    public void GetSliderValue() 
    {
        int multiplier;
        multiplier = 0;
        foreach (Toggle checkmark in checkmarks)
        {
            if (checkmark.isOn)
            {
                multiplier += 1;
                consume.value = 0.33f * multiplier;
            }
        }

        int available;
        available = 0;
        foreach (Toggle checkmark in checkmarks)
        {
            if (!checkmark.isOn)
            {
                available += 1;
                if (available==7) 
                {
                    consume.value = 0;
                }
            }
        }
    }
}
