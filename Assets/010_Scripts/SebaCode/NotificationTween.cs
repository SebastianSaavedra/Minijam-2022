using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class NotificationTween : MonoBehaviour
{
    [SerializeField] float _duration;
    [SerializeField] Transform popupPivot;
    RectTransform goRectT;
    [SerializeField] Slider slider;
    public bool isActive;
    public void Download() 
    {
        StartCoroutine(Download_Notification());       
    }
    public IEnumerator Download_Notification()
    {
        goRectT = gameObject.GetComponent<RectTransform>();
        goRectT.transform.position = popupPivot.transform.position;
        goRectT.transform.localScale = Vector2.zero;
        StartCoroutine(DownloadSlider());
        goRectT.DOScale(Vector2.one, _duration);
        goRectT.DOLocalMove(new Vector3(736, 351), _duration);
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
