using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI actorName;
    //public Text actorMessageText;
    //public Player playerScript;
    public Image dialoguePanel;
    //public Button button1;
    //public Button button2;

    //public int activeReply1;
    //public int activeReply2;
    //public bool isButton1Clicked;
    //public bool isButton2Clicked;
    Coroutine Talk;
    public BobSays bobSays;
    public PhilSays philSays;
    public bool isOpen = false;

    private void Start()
    {
        //philSays.activeMyChoice = 0;
        //philSays.activeReply1 = 1;
        //philSays.activeReply2 = 0;
        //philSays.isButton1Clicked = false;
        //philSays.isButton2Clicked = false;
    }
    private void Update()
    {

    }

    public void OpenDialogue()
    {
        isOpen = true;
        bobSays.BobsReplies();
        philSays.MyChoices();
        PauseGame();
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

    public void EndConvo()
    {
        philSays.activeReply1 = 1;
        philSays.activeReply2 = 0;
        philSays.activeMyChoice = 1;
        Debug.Log("Conversation Ended");
        isOpen = false;
        ResumeGame();
        dialoguePanel.gameObject.SetActive(false);
    }
}