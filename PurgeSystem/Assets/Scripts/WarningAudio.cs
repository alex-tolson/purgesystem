using UnityEngine;

public class WarningAudio : MonoBehaviour
{
    public MissionFailed mission;
    public AudioManager audMan;
    private AudioSource warning;

    // Start is called before the first frame update
    void Start()
    {   
       
        warning = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (mission.playerInRoom)
        {
            audMan.PlayWarningAudio();
        }
 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        StopWarning();
    }
    public void StopWarning()
    {
        warning.Stop();
    }
}
