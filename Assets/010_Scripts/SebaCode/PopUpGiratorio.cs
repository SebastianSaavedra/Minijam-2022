using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpGiratorio : MonoBehaviour
{
    [SerializeField] [Range(1,100)] float speed = 50;
    [SerializeField] Vector3 eje;
    void Update()
    {
        transform.Rotate(eje,speed * Time.deltaTime);
    }
}
