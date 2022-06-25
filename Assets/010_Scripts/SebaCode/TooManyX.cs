using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooManyX : MonoBehaviour
{
    [SerializeField] RectTransform btnX;
    [SerializeField] float offset = 20;

    private void Start()
    {
        float minX = gameObject.GetComponent<RectTransform>().rect.xMin;
        float maxX = gameObject.GetComponent<RectTransform>().rect.xMax;
        float minY = gameObject.GetComponent<RectTransform>().rect.yMin;
        float maxY = gameObject.GetComponent<RectTransform>().rect.yMax;

        btnX.anchoredPosition = new Vector2(Random.Range(minX + offset,maxX - offset), Random.Range(minY + offset, maxY - offset));

        int randomSpawnRate = (int)Random.Range(10,21);
        Debug.Log(randomSpawnRate);
        for (int i = 0; i < randomSpawnRate; i++)
        {
            RectTransform rectObject = Instantiate(GameAssets.i.pf_FakeBtn,transform);
            rectObject.anchoredPosition = new Vector2(Random.Range(minX + offset, maxX - offset), Random.Range(minY + offset, maxY - offset));
        }
    }
}
