using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullscreen_Random : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject sprite;
    [SerializeField] List<GameObject> sprites;
    void Start()
    {
        sprite = sprites[Random.Range(0, sprites.Count)];
        sprite.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
