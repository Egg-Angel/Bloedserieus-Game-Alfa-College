using UnityEngine;

public class RemoveMinigame : MonoBehaviour
{
    public GameObject SetForRemoval;
    public void Remove()
    {
        Destroy(SetForRemoval);
    }
}
