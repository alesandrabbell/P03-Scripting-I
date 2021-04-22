using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Image speakerArt;


    private Queue<string> sentences;
    private Queue<Image> speakerPortraits;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        speakerPortraits = new Queue<Image>();
    }


    public void StartDialogue(Conversation _conversation)
    {
        //speakerArt.sprite = _conversation.characterArt.sprite;
        Debug.Log("Starting convo with " + _conversation.characterName);
        nameText.text = _conversation.characterName;
        


        sentences.Clear();
        speakerPortraits.Clear();

        foreach (string sentence in _conversation.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

        foreach (Image speakerPortrait in _conversation.characterArt)
        {
            speakerPortraits.Enqueue(speakerPortrait);
        }

        DisplaySpeakerPortraits();

    }



    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;


    }

    public void DisplaySpeakerPortraits()
    {
        if(speakerPortraits.Count == 0)
        {
            EndDialogue();
            return;
        }

        Image speakerPortrait = speakerPortraits.Dequeue();
        speakerArt.sprite = speakerPortrait.sprite;

    }


    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }


}
