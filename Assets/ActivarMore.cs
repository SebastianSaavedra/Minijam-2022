using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMore : MonoBehaviour
{
    [SerializeField] List<GameObject> activeWithMe;
    void Start()
    {
        foreach(GameObject paired in activeWithMe) 
        {
            paired.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
