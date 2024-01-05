using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PhilSays : MonoBehaviour
{
    public TextMeshProUGUI  actorMessageText;
    public TextMeshProUGUI playerChoice1;
    public TextMeshProUGUI playerChoice2;
    public TextMeshProUGUI playerChoice3;

    public int activeReply1;
    public int activeReply2;
    public bool isButton1Clicked;
    public bool isButton2Clicked;
    public bool isButton3Clicked;
    public int activeBobsReply;
    public int activeMyChoice;
    public InfoCollected item;

    [SerializeField] private bool _button1, _button2, _button3;
    private void Start()
    {
       // activeBobsReply = 0;
        activeMyChoice = 1;
        activeReply1 = 1;
        activeReply2 = 0;
        isButton1Clicked = false;
        isButton2Clicked = false;
        isButton3Clicked = false;
    }
    public void PlayerChoice1()
    {
        _button1 = true;
        _button2 = false;
        _button3 = false;
    }
    public void PlayerChoice2()
    {
        _button1 = false;
        _button2 = true;
        _button3 = false;
    }

    public void PlayerChoice3()
    {
        _button1 = false;
        _button2 = false;
        _button3 = true;
    }

    IEnumerator ButtonResetCo()
    {
        if ((_button1) || (_button2) || (_button3))

            yield return new WaitForSecondsRealtime(.3f);

        _button1 = false;
        _button2 = false;
        _button3 = false;
    }

    public void ButtonReset()
    {
        StartCoroutine(ButtonResetCo());
    }

    public bool Button1()
    {
        return _button1;
    }
    public bool Button2()
    {
        return _button2;
    }
    public bool Button3()
    {
        return _button3;
    }

    public void MyChoices()
    {
        switch (activeMyChoice)
        {
            case 1:   // "Hey Phil, did you want to talk to me?"
                {
                    if (Button1())
                    {
                        //Debug.Log("How was the concert over the weekend?");
                        activeReply1 = 2;   //The Slick Willies ROCKED.  Nothing like easy listening to kick off the weekend.
                        activeReply2 = 0;
                        

                    }
                    if (Button2())
                    {
                        //Debug.Log("What'd the Doc say?");
                        activeReply1 = 3;
                        activeReply2 = 0;   //It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality
                        

                    }
                    if (Button3())
                    {
                        //Debug.Log("How are yo//Hey Phil! You really should have come to the concert; It was awesome.u, this morning?");
                        activeReply1 = 4;
                        activeReply2 = 0;   

                    }
                    break;
                }
            case 2: // The Slick Willies ROCKED.  Nothing like a little easy listening to kick off the weekend.
                {
                    if (Button1())
                    {
                        //Debug.Log();
                        activeReply1 = 5; //"Too much partying?  What's the wife gonna think?";
                        activeReply2 = 0;
                        

                    }
                    if (Button2())
                    {
                        activeReply1 = 0; //"Did you get your autograph?";
                        activeReply2 = 7;
                        
                        // ButtonReset();
                    }
                    if (Button3())
                    {

                        activeReply1 = 7; //"Maybe we can do a re-watch party at your place?"
                        activeReply2 = 0;
                    }

                    break;
                }
            case 3:  //"It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality"                              
                {
                    if (Button1())
                    {
                        activeReply1 = 8; //"Maybe you could take some time off?";
                        activeReply2 = 0;
                    }

                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && (Button2()))
                    {
                        //"I have the same symptoms as you.  Maybe teach me the exercises too?"

                        activeReply1 = 10; //Winner "Thanks.  Why don't you come over for dinner after work tonight?."
                        activeReply2 = 0;
                        Invoke("EndGame" , .8f);
                    }
                    else if (Button2())
                    {
                        activeReply1 = 0;
                        activeReply2 = 2;//"You can probably find them online.";
                    }

                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && (Button3()))
                    {
                        //"I have the same symptoms as you.  Maybe teach me the exercises too?"

                        activeReply1 = 10; //Winner "Thanks.  Why don't you come over for dinner after work tonight?."
                        activeReply2 = 0;
                        Invoke("EndGame", .8f);
                    }
                    else if (Button3())
                    {

                        activeReply1 = 0;
                        activeReply2 = 11; //"I don't fraternize with subordinates.";
                    }

                    break;
                }

            case 4:
                {

                    if (Button1())
                    {
                        activeReply1 = 5;   //"Too much partying?  What's the wife gonna think?";
                        activeReply2 = 0;
                    }
                    if (Button2())
                    {
                        activeReply1 = 11;
                        activeReply2 = 0; //"I have a dermapatch for that?";
                                          //take away bonuse 1/3 to win.
                    }
                    if (Button3())
                    {
                        activeReply1 = 12;
                        activeReply2 = 0;   //"It's about time you got out and lived a little.";
                    }
                    break;
                }


            case 5: //"Who, Kim? This was her idea!";
                {
                    if (Button1() )
                    {
                        //Debug.Log();
                        activeReply1 = 0; //Better Than You
                        activeReply2 = 1;
                        

                    }
                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && Button2())
                    {
                        activeReply1 = 9; //Winner response
                        activeReply2 = 0;
                        Invoke("EndGame", .8f);
                    }
                   else if (Button2())
                    { 
                        activeReply1 = 7; //"You can probably find them online"
                        activeReply2 = 0;
                        Invoke("EndGame", .8f);
                    }
                    if (Button3())
                    {
                        activeReply1 = 0; 
                        activeReply2 = 5; //"Maybe so... but I AM the boss."
                    }
                    break;
                }

            case 6:
                {
                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && (Button1()))
                    {
                        activeReply1 = 9; //Winner response
                        activeReply2 = 0;
                        Invoke("EndGame", .8f);
                    }
                    else if (Button1())
                    {
                        activeReply1 = 0; 
                        activeReply2 = 8; //maybe some other time
                    }
                    if (Button2())
                    {
                        activeReply1 = 0;                        
                        activeReply2 = 10; //Did you need something? 
                    }
                    if (Button3())
                    {
                        activeReply1 = 0;
                        activeReply2 = 5; //I AM the boss
                    }
                    break;
                }
        
            case 7:
                {
                    
                    if (Button1())
                    {
                        activeReply1 = 0; //Did you need something?
                        activeReply2 = 10;
                    }
                    else if (Button2())
                    {
                        activeReply1 = 0;
                        activeReply2 = 14; //All work and no play makes Jack a dull boy.
                    }
                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && (Button3()))
                    {
                        activeReply1 = 9; //Winner response
                        activeReply2 = 0;
                    }
                    else if (Button3())
                    {
                        activeReply1 = 0;
                        activeReply2 = 11; //I don't fraternize with subordinates.+
                    }
                    break;
                }
                
        
            case 8:
                {
                    if (item.office1Item && item.alexofficeItem && item.office2Item && item.office0Item && (Button1()))
                    {
                        activeReply1 = 9; //Winner response
                        activeReply2 = 0;
                        Invoke("EndGame", .8f);
                    }
                    //"Who's gonna carry this workload while I'm gone?";
                    else if (Button1())
                    {
                        activeReply1 = 7; 
                        activeReply2 = 0 ; //Can you teach me the exercises too?";
                    }
                    if (Button2())
                    {
                        activeReply1 = 0;
                        activeReply2 = 12; //That's a fair point
                    }
                    if (Button3())
                    {
                        activeReply1 = 0;
                        activeReply2 = 13; //"If you and Kim need anything, I'll help out as I can.";
                    }
                    break;
                }
            default:
                {
                    playerChoice1.text = "(no comment)";
                    playerChoice2.text = "(no comment)";
                    playerChoice3.text = "(no comment)";
                    break;
                }
        }       
    }

    private void EndGame()
    {
        SceneManager.LoadScene(3);
    }
}
