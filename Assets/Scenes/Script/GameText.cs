using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
}

public class GameText : MonoBehaviour
{
    public Text txt_Dialogue;

    private bool isDialogue = false;

    private int count = 0;

    [SerializeField] private Dialogue[] dialogues;

    public void ShowDialogue()
    {
        OnOff(true);

        count = 0;
        isDialogue = true;
    }

    private void OnOff(bool _flag)
    {
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = false;
    }


    private void NextDialogue()
    {
        txt_Dialogue.text = dialogues[count].dialogue;
        count++;
    }
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogues.Length)
                    NextDialogue();
                else
                    OnOff(false);
            }
        }
    }
}
