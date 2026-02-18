using UnityEngine;

public class MaandverbandGameController : MonoBehaviour
{
    public static MaandverbandGameController instance { get; private set; }

    public GameObject MaandverbandStartpanel;
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

    public void ShowMaandverbandGameUI(bool show)
    {
        MaandverbandStartpanel.SetActive(show); // toggle UI visability
    }
}
