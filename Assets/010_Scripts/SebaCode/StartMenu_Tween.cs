using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartMenu_Tween : MonoBehaviour
{
    //[SerializeField] RectTransform pivot;
    [SerializeField] float _duration = 1;
    RectTransform goRectT;

    private void Start()
    {
        goRectT = gameObject.GetComponent<RectTransform>();
    }

    public void OpenStartMenu()
    {
        //goRectT.transform.position = pivot.transform.position;
        goRectT.transform.localScale = Vector2.zero;

        goRectT.DOScale(Vector2.one, _duration);
        //goRectT.DOLocalMove(new Vector2(-747.82f, -411.6f), _duration);
    }
    public void CloseStartMenu()
    {
        goRectT.DOScale(Vector2.zero, _duration);
        //goRectT.DOLocalMove(pivot.transform.position, _duration);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
