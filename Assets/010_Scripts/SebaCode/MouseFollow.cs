using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    [SerializeField] float pushPower = 150f;
    [SerializeField] float distance = 400f;
    [SerializeField] Rigidbody2D rb;
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("laposicionesdelmouses: "+Input.mousePosition);
        //}

        if (Vector2.Distance(Input.mousePosition, transform.position) < distance)   // No sigue al mouse por ?????? razon.
        {
            Vector3 dir = transform.position - Input.mousePosition;
            dir = dir.normalized;

            rb.AddForce(dir * -pushPower, ForceMode2D.Impulse);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
