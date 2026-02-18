using UnityEngine;

public class NextStep : MonoBehaviour
{
    public GameObject EnableNextStep;
    public GameObject DisableCurrentStep;

    public void ButtonClicked()
    {
        EnableNextStep.SetActive(true);
        DisableCurrentStep.SetActive(false);
    }

}
