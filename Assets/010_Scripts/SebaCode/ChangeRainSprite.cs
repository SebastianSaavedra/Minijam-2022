using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRainSprite : MonoBehaviour
{
    void Start()
    {
        switch (PopManager.instancia.fase)
        {
            default:
                break;
            case 1:
                gameObject.GetComponent<Image>().sprite = GameAssets.i.rainParticle1;
                break;
            case 2:
                gameObject.GetComponent<Image>().sprite = GameAssets.i.rainParticle2;
                break;
            case 3:
                gameObject.GetComponent<Image>().sprite = GameAssets.i.rainParticle3;
                break;
        }
    }
}
