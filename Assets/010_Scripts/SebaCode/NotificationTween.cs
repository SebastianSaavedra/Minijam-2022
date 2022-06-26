using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NotificationTween : MonoBehaviour
{
    [SerializeField] float _duration;
    [SerializeField] Transform popupPivot;
    RectTransform goRectT;
    public void Download_Notification()
    {
        goRectT = gameObject.GetComponent<RectTransform>();
        goRectT.transform.position = popupPivot.transform.position;
        goRectT.transform.localScale = Vector2.zero;

        goRectT.DOScale(Vector2.one, _duration);
        goRectT.DOLocalMove(new Vector3(736, 351), _duration);
    }
}
