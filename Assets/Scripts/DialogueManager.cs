using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public static DialogueManager Instance { get; set; }

    string npcName;
    List<string> dialogueLines = new List<string>();

    public GameObject dialoguePanel;
    Button continueButton;
    Text dialogueText, nameText;
    int dialogueIndex;

    void Awake ()
    {
        continueButton = dialoguePanel.transform.Find("Continue").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.Find("Name").GetChild(0).GetComponent<Text>();

        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });

        dialoguePanel.SetActive(false);

		if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
	}
	
	public void AddNewDialogue(string[] Lines, string _NPCName = "Unkown")
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>(Lines.Length);
        dialogueLines.AddRange(Lines);

        npcName = _NPCName;


        CreateDialogue();
        Debug.Log(dialogueLines.Count);
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueText.text = dialogueLines[++dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
