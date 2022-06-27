using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomAd : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image sprite;
    [SerializeField] List<Sprite> sprites;
    void Start()
    {
        sprite.sprite = sprites[Random.Range(0,sprites.Count)];
    }

    public void Randomize() 
    {
        sprite.sprite = sprites[Random.Range(0, sprites.Count)];
    }


}
