using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCharacter
{
    public string name;
    public Sprite icon;
}

[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea(3, 10)]
    public string line;
}

[System.Serializable]
public class Dialogue
{
    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
}

public class DialogueTrigger : MonoBehaviour, IInteractable
{
    public Dialogue dialogue;


    public bool CanInteract()
    {
        DialogueManager talking = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
        return !talking.isDialogueActive;
    }

    public void Interact()
    {
        DialogueManager talking = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();

        if (talking.isDialogueActive)
        {
            talking.DisplayNextDialogueLine();
        }
        else
        {
            DialogueManager.Instance.StartDialogue(dialogue);

        }
    }

}
