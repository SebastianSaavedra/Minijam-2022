using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SiOffset : MonoBehaviour
{
    [SerializeField] RectTransform offSetGameobject;
    Vector3 offset;
    RectTransform me;
    private void Start()
    {
        me = GetComponent<RectTransform>();
        offset = me.transform.localPosition- offSetGameobject.transform.localPosition;
    }

    private void Update()
    {
        me.anchoredPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offSetGameobject.localPosition = new Vector3(me.transform.localPosition.x-offset.x, me.localPosition.y - offset.y, 0);
    }
}
