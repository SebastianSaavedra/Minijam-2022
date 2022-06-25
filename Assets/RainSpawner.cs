using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    [SerializeField] GameObject rain;
    [SerializeField] float raintimer,spread,amount;
    float timeReset;
    public  bool canRain;
    void Start()
    {
        timeReset = raintimer;
        InvokeRepeating("RainMaker",amount,amount);
    }

    // Update is called once per frame
    private void Update()
    {
        if (canRain) 
        {
            raintimer -= Time.deltaTime;
            if (raintimer <= 0) 
            {
                raintimer = timeReset;
                canRain = false;
            }
        }
    }

    void RainMaker() 
    {
        if (canRain) 
        {
        GameObject rainObject = Instantiate(rain, transform);
        RectTransform rainPos = rainObject.GetComponent<RectTransform>();
        rainPos.localPosition = new Vector3(Random.Range(-spread,spread),0,0);
            Destroy(rainObject, 5);
        }
    }
}
