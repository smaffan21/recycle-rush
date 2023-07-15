using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class QuestionAndAnswers
{
    public string Question;
    public string [] Answers;
    public int correctAns;
}
 
public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public Text questionText;
    int totalQuestions = 0;

    private void Start() 
    {
        totalQuestions = QnA.Count;
        GenerateQuestion();
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }
    void SetAnswers() 
    {
        for (int i = 0; i < options.Length ; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].correctAns == i+1) 
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void GenerateQuestion() 
    {
        if(QnA.Count > 0) 
        {
            currentQuestion = Random.Range(0, QnA.Count);
            questionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else 
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadSceneAsync(currentSceneIndex + 1);
            SceneManager.UnloadScene(currentSceneIndex);
        }
        
    }
}
