using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;

public class NotificationTween : MonoBehaviour
{
    [SerializeField] float _duration;
    [SerializeField] Transform popupPivot;
    RectTransform goRectT;
    [SerializeField] Slider slider;
    public bool isActive,isThaks;
    UnityAction listener;
    private void Start()
    {
        listener = new UnityAction(Thanks); 
        PopManager.StartListening("Thanks",Thanks);
    }
    public void Download() 
    {
        StartCoroutine(Download_Notification());       
    }

    public void Thanks() 
    {
        if (isThaks) 
        {
            Debug.Log("Thanks");
            Download();
        }
    }
    public IEnumerator Download_Notification()
    {
        goRectT = gameObject.GetComponent<RectTransform>();
        goRectT.transform.position = popupPivot.transform.position;
        goRectT.transform.localScale = Vector2.zero;
        if (!isThaks) 
        {
        StartCoroutine(DownloadSlider());
        }
        goRectT.DOScale(Vector2.one, _duration);
        if (isThaks) 
        {
        goRectT.DOLocalMove(new Vector3(779, -380), _duration);
        }
        else 
        {
        goRectT.DOLocalMove(new Vector3(736, 351), _duration);
        }
        isActive = true;
        PopManager.instancia.ram -= 1;
        yield return new WaitForSeconds(5f);
        goRectT.DOScale(Vector2.zero, _duration);
        goRectT.DOLocalMove(popupPivot.position, _duration);
        yield break;
    }

    IEnumerator DownloadSlider() 
    {
        slider.DOValue(1,10);
        yield return new WaitForSeconds(10);
        isActive = false;
        slider.value = 0;
        PopManager.instancia.ram += 1;
        yield break;
    }
}
