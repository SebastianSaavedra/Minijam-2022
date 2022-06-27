using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField]List<string> question,answerA,answerB;
    [SerializeField] SuperTextMesh questionG, answerAG, answerBG;
    void Start()
    {
        int ran = Random.Range(0,question.Count);
        questionG.text = question[ran];
        answerAG.text = answerA[ran];
        answerBG.text = answerB[ran];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
