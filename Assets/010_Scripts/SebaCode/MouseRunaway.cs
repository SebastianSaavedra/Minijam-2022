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
            if (Vector2.Distance(Input.mousePosition, transform.position) < distance)
            {
                Vector3 dir = transform.position - Input.mousePosition;
                dir = dir.normalized;

                rb.AddForce(dir * pushPower, ForceMode2D.Force);

                //rb.velocity = dir * pushPower;
            }
        }
    }
}
