using UnityEngine;

public class InteractTest : MonoBehaviour, IInteractable
{
    // so this script gives an error whenever the play gets within interaction range of the object that holds this script
    //i am hoping this means it works

    public void Interact()
    {
        Debug.Log("please work");
    }


}
