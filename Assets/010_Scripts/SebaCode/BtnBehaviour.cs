using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BtnBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField] GameObject highlight;
    [SerializeField] bool isTicket;
    Image btnImage;

    private void Start()
    {
        if (isTicket)
        {
            btnImage = GetComponent<Image>();
        }      
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (isTicket)
        {
            btnImage.sprite = GameAssets.i.ticket;
            btnImage.color = new Vector4(1, 1, 1, 1);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (highlight != null || !isTicket)
            highlight.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (highlight != null || !isTicket)
            highlight.SetActive(false);
    }
}
