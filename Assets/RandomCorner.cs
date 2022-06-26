using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCorner : MonoBehaviour
{
    [SerializeField]RectTransform rectTransform;
    Vector2 anchirmin;
    Vector2 anchirMax;
    Vector2 pivot;
    [SerializeField] float timer;
    public RectTransform child;

    private void Start()
    {
        InvokeRepeating("Corner",timer,timer);
    }
    public void Corner() 
    {
    
        int val = Random.Range(0,4);
        switch (val) 
        {
            case 0:
                anchirmin = new Vector2(0,1);
                anchirMax = new Vector2(0,1);
                if(rectTransform.anchorMin== anchirmin && rectTransform.anchorMax == anchirMax) 
                {
                    Corner();
                }
                else 
                {
                rectTransform.anchorMin = anchirmin;
                rectTransform.anchorMax = anchirMax;
                    rectTransform.anchoredPosition = new Vector2(238.5704f, -129.5671f);
                }
                break;
            case 1:
                    anchirmin = new Vector2(1, 1);
                    anchirMax = new Vector2(1, 1);
                if (rectTransform.anchorMin == anchirmin && rectTransform.anchorMax == anchirMax)
                {
                    Corner();
                }
                else
                {
                    rectTransform.anchorMin = anchirmin;
                    rectTransform.anchorMax = anchirMax;
                    rectTransform.anchoredPosition = new Vector2(-238.5704f, -129.5671f);
                }
                break;
            case 2:
                    anchirmin = new Vector2(0, 0);
                    anchirMax = new Vector2(0, 0);
                if (rectTransform.anchorMin == anchirmin && rectTransform.anchorMax == anchirMax)
                {
                    Corner();
                }
                else
                {
                    rectTransform.anchorMin = anchirmin;
                    rectTransform.anchorMax = anchirMax;
                    rectTransform.anchoredPosition = new Vector2(238.5704f, 129.5671f);
                }
                break;
            case 3:
                    anchirmin = new Vector2(1, 0);
                    anchirMax = new Vector2(1, 0);
                if (rectTransform.anchorMin == anchirmin && rectTransform.anchorMax == anchirMax)
                {
                    Corner();
                }
                else
                {
                    rectTransform.anchorMin = anchirmin;
                    rectTransform.anchorMax = anchirMax;
                    rectTransform.anchoredPosition = new Vector2(-238.5704f, 129.5671f);
                }
                break;
        }

        child.localPosition = Vector3.zero;
    }
}
