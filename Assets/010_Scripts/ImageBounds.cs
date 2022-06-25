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
    [SerializeField] bool canDrag;
    public bool isRandom;
    [SerializeField] bool hasVariant;
    [SerializeField] List<GameObject> variant;

    void Start() 
    {
        if (hasVariant) 
        {
            variant[Random.Range(0, variant.Count)].SetActive(true);
        }
    }
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
        if (canDrag) 
        {
        transform.position = MousePos() +_dragOffSet;
        }
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
