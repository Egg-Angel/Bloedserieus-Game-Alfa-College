using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    public Button InfoButton;


    void Update()
    {
        if (PauseController.IsGamePaused)
        {
            InfoButton.interactable = false;
        }
        if (PauseController.IsGamePaused == false)
        {
            InfoButton.interactable = true;
        }
    }

}
