using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnInCanvas : MonoBehaviour
{
    [SerializeField] float timePeriod = 0.5f;
    [SerializeField] PopManager preguntas;
    [SerializeField] Transform canvas;
    [SerializeField] int pop, preguntaInt;
    public bool preguntaOnCanvas;
    void Start()
    {
        InvokeRepeating("Spawner",timePeriod,timePeriod);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        if (!preguntaOnCanvas) 
        {
        if (Random.value > 0.5) //%50 percent chance
        {
                Debug.Log("A");
        }

       else if (Random.value > 0.2) //%80 percent chance (1 - 0.2 is 0.8)
        {
                Debug.Log("B");
                GameObject pregunta = Instantiate(preguntas.pops[0], canvas);
            RectTransform preguntaPos = pregunta.GetComponent<RectTransform>();
                if (!preguntaPos.GetComponent<RandomCorner>()) 
                {
            preguntaPos.localPosition = new Vector3(Random.Range(pregunta.GetComponent<ImageBounds>().minX, pregunta.GetComponent<ImageBounds>().maxX)
                , Random.Range(pregunta.GetComponent<ImageBounds>().minY, pregunta.GetComponent<ImageBounds>().maxY), 0);
                }
                else 
                {
                    preguntaPos.GetComponent<RandomCorner>().Corner();
                }
            Destroy(pregunta, 5);
            pop += 1;
        }

       else if (Random.value > 0.95 && !PopManager.cor) //%5percent chance (1 - 0.7 is 0.3)
        { //code here
            GameObject pregunta = Instantiate(preguntas.pops[1], canvas);
            RectTransform preguntaPos = pregunta.GetComponent<RectTransform>();
            preguntaPos.localPosition = new Vector3(Random.Range(pregunta.GetComponent<ImageBounds>().minX, pregunta.GetComponent<ImageBounds>().maxX)
                , Random.Range(pregunta.GetComponent<ImageBounds>().minY, pregunta.GetComponent<ImageBounds>().maxY), 0);
            //Destroy(pregunta, 5);
            preguntaInt += 1;
        }
        }

       
    }
}
