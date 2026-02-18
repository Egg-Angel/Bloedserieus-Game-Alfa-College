using UnityEngine;

public class MaandverbandGame : MonoBehaviour, IInteractable
{
    private MaandverbandGameController MaandverbandGameUI;

    private bool isMaandverbandGameActive;

    void Start()
    {
        MaandverbandGameUI = MaandverbandGameController.instance;
    }

    public bool CanInteract()
    {
        return !isMaandverbandGameActive;
    }

    public void Interact()
    {
        if (PauseController.IsGamePaused && !isMaandverbandGameActive)
        {
            return;
        }
        else
        {
            StartMaandverbandGame();

        }
    }

    void StartMaandverbandGame()
    {
        MaandverbandGameUI.ShowMaandverbandGameUI(true);
    }
}
