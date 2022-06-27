using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCrossPosition : MonoBehaviour
{
    [SerializeField] List<Transform> pivots = new List<Transform>();
    [SerializeField] float distance = 100f;
    [SerializeField] float timer = 0;

    void Update()
    {
        if (Vector2.Distance(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.position) < distance)
        {
            timer += Time.deltaTime;
            if (timer >= .4f)
            {
                Transform pivot = pivots[Random.Range(0, pivots.Count)];
                if (pivot.transform.position == transform.position)
                {
                    pivot = pivots[Random.Range(0, pivots.Count)];
                }
                transform.position = new Vector2(pivot.transform.position.x, pivot.transform.position.y);
                timer = 0;
            }
        }
    }
}
