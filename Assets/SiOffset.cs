using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiOffset : MonoBehaviour
{
    [SerializeField] GameObject offSetGameobject;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position- offSetGameobject.transform.position;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
        offSetGameobject.transform.position = new Vector3(transform.position.x-offset.x, transform.position.y - offset.y, 0);
    }
}
