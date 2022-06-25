using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageBounds : MonoBehaviour,IDragHandler,IEndDragHandler,IBeginDragHandler
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    Vector3 _dragOffSet;


    Vector3 MousePos()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 0;
        return mousePos;
    }
    public void OnBeginDrag(PointerEventData eventData) 
    {
        _dragOffSet = transform.position - MousePos();
    }
    public void OnDrag(PointerEventData eventData) 
    {
        transform.position = MousePos() +_dragOffSet;
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
