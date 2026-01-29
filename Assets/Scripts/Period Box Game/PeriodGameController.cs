using UnityEngine;

public class PeriodGameController : MonoBehaviour
{
    public static PeriodGameController instance { get; private set; }


    public GameObject insideboxPanel;
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

    public void ShowPeriodGameUI(bool show)
    {
        insideboxPanel.SetActive(show); // toggle UI visability
    }
}
