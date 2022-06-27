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

        if (Vector2.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position) < distance)
        {
            Vector3 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            dir.z = 0;
            dir = dir.normalized;

            rb.AddForce(dir * -pushPower, ForceMode2D.Impulse);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
