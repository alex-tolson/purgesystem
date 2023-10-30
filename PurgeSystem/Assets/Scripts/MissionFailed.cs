using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionFailed : MonoBehaviour
{
    public bool playerInRoom;
    public bool peopleInRoom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D (Collider2D other)
    {
        if (other.CompareTag("People"))
        {
            if (playerInRoom == true)
            {
                SceneManager.LoadScene("MissionFailed");
            }
        }
         if (other.CompareTag("Player"))
        {
            if (peopleInRoom == true)
            {
                SceneManager.LoadScene("MissionFailed");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRoom = true;
        }
        if (other.CompareTag("People"))
        {
            peopleInRoom = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRoom = false;
        }
        if (other.CompareTag("People"))
        {
            peopleInRoom = false;
        }
    }
}
