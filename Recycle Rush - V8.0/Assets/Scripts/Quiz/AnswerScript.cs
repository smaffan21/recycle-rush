using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public AudioSource src;
    public AudioClip correct, wrong;
    public bool isCorrect = false;
    public QuizManager qM;
    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            src.clip = correct;
            src.Play();
            qM.correct();
        }
        else 
        {
            Debug.Log("Wrong Answer");
            src.clip = wrong;
            src.Play();
        }
    }
}
