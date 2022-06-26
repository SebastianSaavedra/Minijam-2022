using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Popup_Fullscreen : MonoBehaviour
{
    [SerializeField] Transform pivot;
    [SerializeField] float _duration = 1;
    RectTransform goRectT;
    public bool isActive;
  public void Fullscreen()
    {
        goRectT = gameObject.GetComponent<RectTransform>();
        goRectT.transform.position = pivot.transform.position;
        goRectT.transform.localScale = Vector2.zero;

        goRectT.DOScale(Vector2.one,_duration);
        goRectT.DOLocalMove(Vector2.zero,_duration);
        isActive = true;
    }

    IEnumerator CloseCor() 
    {
        //goRectT.transform.position = pivot.transform.position;
      //  goRectT.transform.localScale = Vector2.zero;

        goRectT.DOScale(Vector2.zero, _duration);
        goRectT.DOLocalMove(pivot.transform.localPosition, _duration);
        yield return new WaitForSeconds(_duration);
        isActive = false;
        yield break;
    }
    public void Close() 
    {
        StartCoroutine(CloseCor());
    }

    public void ToggleFirewall() 
    {
        Debug.Log("Firewall");
        if (!isActive) 
        {
            Fullscreen();
        }
        else 
        {
            Close();
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        goRectT.transform.position = pivot.transform.position;
    //        goRectT.transform.localScale = Vector2.zero;

    //        goRectT.DOScale(Vector2.one, _duration);
    //        goRectT.DOLocalMove(Vector2.zero, _duration);
    //    }
    //}
}
