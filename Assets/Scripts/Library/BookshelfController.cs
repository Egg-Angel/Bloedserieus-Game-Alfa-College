using UnityEngine;

public class BookshelfController : MonoBehaviour
{
    public static BookshelfController instance { get; private set; }

    public GameObject Bookcase;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ShowBookshelfGameUI(bool show)
    {
        Bookcase.SetActive(show); // toggle UI visability
    }
}
