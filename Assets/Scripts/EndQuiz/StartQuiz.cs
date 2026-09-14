using UnityEngine;

public class StartQuiz : MonoBehaviour
{
    public GameObject QuizStart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        QuizStart.SetActive(true);
    }
        

}
