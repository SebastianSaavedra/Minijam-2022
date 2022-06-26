using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlitchButton : MonoBehaviour
{
    [SerializeField] GameObject shaderObject;
    [SerializeField] Button glitchedBtn;
    float _time;
    float time;
    [SerializeField] float timerGlitch,timerNotGlitch;
    Material _material;

    private void Start()
    {
        _material = shaderObject.GetComponent<Image>().material;
    }
    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= timerGlitch)
        {
            _material.SetFloat("_ChromAberrAmount", 0);
            _material.SetFloat("_GlitchAmount", 0);
            _material.SetFloat("_FlickerFreq", 0);
            _material.SetFloat("_PixelateSize", 100);
            _material.SetFloat("_HandDrawnAmount", 0);
            _material.SetFloat("_DistortAmount", 0);
            glitchedBtn.interactable = true;
            time += Time.deltaTime;
            if (time >= timerNotGlitch)
            {
                _time = 0;
                time = 0;
            }
        }
        else
        {
            _material.SetFloat("_ChromAberrAmount", 1);
            _material.SetFloat("_GlitchAmount", 20);
            _material.SetFloat("_FlickerFreq", .2f);
            _material.SetFloat("_PixelateSize", 10);
            _material.SetFloat("_HandDrawnAmount", 20);
            _material.SetFloat("_DistortAmount", .5f);
            glitchedBtn.interactable = false;
        }
    }
}
