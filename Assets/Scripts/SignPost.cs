using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPost : ActionItem {
    public string[] dialogue;
    public override void Interact()
    {
        DialogueManager.Instance.AddNewDialogue(dialogue, "Sign Post");
        Debug.Log("Interaction with sign post");
    }
}
