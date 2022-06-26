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
            glitchedBtn.interactable = false;
        }
    }
}
