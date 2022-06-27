using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebaCode
{
    public class MouseRunaway : MonoBehaviour
    {
        [SerializeField] float pushPower = 50.0f;
        [SerializeField] float distance;
        [SerializeField] Rigidbody2D rb;
        void Update()
        {
            if (Vector2.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position) < distance)
            {
                Vector3 dir = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                dir.z = 0;
                dir = dir.normalized;

                rb.AddForce(dir * pushPower, ForceMode2D.Impulse);

                //rb.velocity = dir * pushPower;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
