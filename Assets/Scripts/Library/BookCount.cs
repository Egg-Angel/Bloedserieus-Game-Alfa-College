using UnityEngine;

public class BookCount : MonoBehaviour
{
    public int totalBooks = 0;

    public void PlusBook()
    {
        totalBooks++;
        Debug.Log("Books: " + totalBooks);
    }

    private void Update()
    {

        if (totalBooks == 4)
        {
            Debug.Log("you collected all books!");
        }

    }
}