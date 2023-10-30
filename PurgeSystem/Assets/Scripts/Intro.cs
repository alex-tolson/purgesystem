using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public Button proceedButton;

    public void ProceedToInstructions()
    {
        ResumeGame();
        SceneManager.LoadScene("Instructions");
    }

    public void ProceedToGame()
    {
        ResumeGame();
        SceneManager.LoadScene("OfficeFloor1");
    }

    public void BackToIntro()
    {
        ResumeGame();
        SceneManager.LoadScene("LandingPage");
    }

    public void MissionComplete()
    {
        ResumeGame();
        SceneManager.LoadScene("MissionComplete");
    }

    public void AppQuit()
    {
        Application.Quit();
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
}
