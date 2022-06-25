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
        if (Vector2.Distance(Input.mousePosition, transform.position) < distance)
        {
            Vector3 dir = Input.mousePosition;
            dir = dir.normalized;

            //rb.AddForce(dir * pushPower * Time.deltaTime, ForceMode2D.Force);

            rb.velocity = dir * pushPower;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
