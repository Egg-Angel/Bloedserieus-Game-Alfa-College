using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int QuizScore = 0;


    public void ClickedOnTrue()
    {
        QuizScore++;
    }


}
