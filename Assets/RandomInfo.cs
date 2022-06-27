using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInfo : MonoBehaviour
{
    [SerializeField] List<GameObject> fase1,fase2,fase3;


    private void Start()
    {
        switch (PopManager.instancia.fase) 
        {
            case 1:
                fase1[Random.Range(0, fase1.Count)].SetActive(true);
                break;
            case 2:
                fase2[Random.Range(0, fase2.Count)].SetActive(true);
                break;
            case 3:
                fase3[Random.Range(0, fase3.Count)].SetActive(true);
                break;
        }
    }
}
