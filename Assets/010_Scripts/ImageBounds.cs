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
    [SerializeField] bool hasVariant,isCorner;
    [SerializeField] List<GameObject> variant1;
    [SerializeField] List<GameObject> variant2;
    [SerializeField] List<GameObject> variant3;

    void Start() 
    {
        if (hasVariant) 
        {
            switch (PopManager.instancia.fase) 
            {
                case 1:
                   int randomvariant= Random.Range(0, variant1.Count);
                   variant1[randomvariant].SetActive(true);

                    break;
                case 2:
                    int randomvariant2 = Random.Range(0, variant2.Count);
                    variant2[randomvariant2].SetActive(true);

                    break;
                case 3:
                    int randomvariant3 = Random.Range(0, variant3.Count);
                    variant3[randomvariant3].SetActive(true);
                    break;
            }
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
