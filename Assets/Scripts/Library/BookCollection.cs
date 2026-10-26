using UnityEngine;

public class BookCollection : MonoBehaviour, IInteractable
{
    private BookshelfController BookshelfGameUI;

    private bool isBookshelfActive;

    void Start()
    {
        BookshelfGameUI = BookshelfController.instance;
    }

    public bool CanInteract()
    {
        return !isBookshelfActive;
    }

    public void Interact()
    {
        if (PauseController.IsGamePaused && !isBookshelfActive)
        {
            return;
        }
        else
        {
            StartBookshelfGame();
            PauseController.SetPause(true);

        }

    }

    void StartBookshelfGame()
    {
        BookshelfGameUI.ShowBookshelfGameUI(true);
    }
}