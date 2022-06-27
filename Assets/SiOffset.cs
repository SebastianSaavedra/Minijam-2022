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
        // me.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 posmouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posmouse.z = 0;
        me.position = posmouse;
        offSetGameobject.localPosition = new Vector3(me.transform.localPosition.x-offset.x, me.localPosition.y - offset.y, 0);
    }
}
