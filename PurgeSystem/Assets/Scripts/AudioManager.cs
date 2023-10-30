using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource office;
    public AudioSource keyboard;
    public AudioSource paper;
    public AudioClip warning;
    private AudioSource _audioSource;
    Coroutine WarningCo;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        WarningCo = null;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayOffice()
    {
        office.Play();
    }

    public void PlayKeyboard()
    { 
        keyboard.Play();
    }

    public void PlayPaper()
    {
        paper.Play();
    }

    public void PlayWarningAudio()
    { 
        _audioSource.PlayOneShot(warning, .1f);
    }

    IEnumerator PlayWarningCorou()
    {
        PlayWarningAudio();
        Debug.Log("Play Warning audio");
        yield return new WaitForSeconds(0.01f);
        WarningCo = null;
    }

    public void PlayWarningMethod()
    {
        if (WarningCo != null)
        {
            return;
        }
        else
        {
            WarningCo = StartCoroutine(PlayWarningCorou());
        }
    }

}
