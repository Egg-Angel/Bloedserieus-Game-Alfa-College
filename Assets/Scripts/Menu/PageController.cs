using UnityEngine;

public class PageController : MonoBehaviour
{

    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameObject.SetActive(false);
            }
        }
    }
}
