using UnityEngine;

public class BookCollection : MonoBehaviour, IInteractable
{
    [SerializeField] BookCount Counting;

    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {

        if (Counting != null)
        {
            Counting.PlusBook();
        }

        Destroy(gameObject);
    }
}