using UnityEngine;

public class InfoButton : MonoBehaviour
{
    public GameObject InfoBook;

    public void OpenBook()
    {
        if (InfoBook.activeSelf == false)
        {
            InfoBook.SetActive(true);
            PauseController.SetPause(true);
        }
        else
        {
            InfoBook.SetActive(false);
            PauseController.SetPause(false);
        }
        
    }
}
