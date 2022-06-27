using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YouLose : MonoBehaviour
{
    [SerializeField] GameObject tab;
    [SerializeField] Material _material;
    [SerializeField] float _duration;

    public void Start()
    {
        _material.DOFloat(.6f, "_GhostTransparency",_duration);
        tab.transform.position = Vector2.zero;
        tab.transform.localScale = Vector2.zero;
        tab.transform.DOScale(Vector2.one,_duration * 1.5f);
    }

    public void ResetValue()
    {
        _material.SetFloat("_GhostTransparency",1f);
    }
}
