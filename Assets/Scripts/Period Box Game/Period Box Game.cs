using UnityEngine;

public class PeriodBoxGame : MonoBehaviour, IInteractable
{

    private PeriodGameController periodGameUI;

    private bool isPeriodboxActive;
    void Start()
    {
        periodGameUI = PeriodGameController.instance;
    }

    public bool CanInteract()
    {
        return !isPeriodboxActive;
    }

    public void Interact()
    {
        if (PauseController.IsGamePaused && !isPeriodboxActive)
        {
            return;
        }
        else
        {
            StartPeriodGame();

        }
    }

    void StartPeriodGame()
    {
        periodGameUI.ShowPeriodGameUI(true);
    }


    public void EndDialogue()
    {
        isPeriodboxActive = false;
        periodGameUI.ShowPeriodGameUI(false);
    }
}
