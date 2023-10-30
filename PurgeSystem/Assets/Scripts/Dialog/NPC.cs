using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    public Button button1;

    public Button WinGame;
    public Image dialogueBox;

    public DialogueManager dm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dm.OpenDialogue();
            dialogueBox.gameObject.SetActive(true);

        }
    }

    public void ShowNext()
    {
        WinGame.gameObject.SetActive(true);
        button1.gameObject.SetActive(false);
    }

    public void Win()
    {
        SceneManager.LoadScene("MissionComplete");
    }
}
