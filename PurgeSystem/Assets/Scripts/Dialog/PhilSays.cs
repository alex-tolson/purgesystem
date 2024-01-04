using System.Collections;
using UnityEngine;

using TMPro;

public class PhilSays : MonoBehaviour
{
    public TextMeshProUGUI  actorMessageText;
    public TextMeshProUGUI playerChoice1;
    public TextMeshProUGUI playerChoice2;
    public TextMeshProUGUI playerChoice3;

    public int activeReply1;
    public int activeReply2;
    public int activeReply3;
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
        activeReply3 = 0;
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
                        activeReply1 = 2;   //The Slick Willies ROCKED.  Nothing like a little easy listening to kick off the weekend.
                        activeReply2 = 0;
                        activeReply3 = 0;

                    }
                    if (Button2())
                    {
                        //Debug.Log("What'd the Doc say?");
                        activeReply1 = 0;
                        activeReply2 = 3;   //It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality
                        activeReply3 = 0;

                    }
                    if (Button3())
                    {
                        //Debug.Log("How are you, this morning?");
                        activeReply1 = 0;
                        activeReply2 = 0;
                        activeReply1 = 4;   //Hey Phil! You really should have come to the concert; It was awesome.

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
                        activeReply3 = 0;

                    }
                    if (Button2())
                    {
                        activeReply1 = 0; //"Did you get your autograph?";
                        activeReply2 = 6;
                        activeReply3 = 0;
                        // ButtonReset();
                    }
                    if (Button3())
                    {

                        activeReply1 = 0; //"Maybe we can do a re-watch party at your place?"
                        activeReply2 = 0;
                        activeReply1 = 7;
                    }

                    break;
                }
            case 3:  //"It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality"                              
                {
                    if (Button1())
                    {
                        activeReply1 = 8; //"Maybe you could take some time off?";
                        activeReply2 = 0;
                        activeReply3 = 0;

                    }

                    if ((item.office1Item) && (item.office2Item) && (item.office3Item) && (item.alexofficeItem) && (Button2()))
                    {
                        //"I have the same symptoms as you.  Maybe teach me the exercises too?"

                        activeReply1 = 10; //Winner "Thanks.  Why don't you come over for dinner after work tonight?."
                        activeReply2 = 0;
                        activeReply3 = 0;

                    }
                    else if (Button2())
                    {
                        activeReply1 = 0;
                        activeReply2 = 14;//"You can probably find them online.";
                        activeReply3 = 0;

                    }
                    if (Button3())
                    {

                        activeReply1 = 0;
                        activeReply2 = 3;   //It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality
                        activeReply3 = 0;

                    }

                    break;
                }

            case 4:
                {
                    actorMessageText.text = "I slept like garbage.  Stayed up too late.  Ugh, my head!";
                    {
                        if ((item.office1Item) && (Button1()) || (Button2()))
                        {
                            activeReply1 = 9;
                            ButtonReset();
                        }
                        else if (Button1())
                        {

                            activeReply1 = 5;   //"Too much partying?  What's the wife gonna think?";
                            activeReply2 = 0;
                            activeReply3 = 0;

                        }
                        if (Button2())
                        {
                            activeReply1 = 0;
                            activeReply2 = 11; //"I have a dermapatch for that?";
                            activeReply3 = 0;

                        }
                        if (Button3())
                        {
                            activeReply1 = 0;
                            activeReply2 = 0;
                            activeReply3 = 12;   //"It's about time you got out and lived a little.";
                        }
                        break;
                    }
                }

            case 5:
                {
                    if (Button1())
                    {
                        //Debug.Log();
                        activeReply1 = 5; //"Too much partying?  What's the wife gonna think?";
                        activeReply2 = 0;
                        activeReply3 = 0;

                    }
                    if (Button2())
                    {
                        activeReply1 = 0; //"Did you get your autograph?";
                        activeReply2 = 6;
                        activeReply3 = 0;
                        // ButtonReset();
                    }
                    if (Button3())
                    {

                        activeReply1 = 0; //"Maybe we can do a re-watch party at your place?"
                        activeReply2 = 0;
                        activeReply3 = 7;

                    }
                }
                break;

            case 6:
                {
                    if ((item.office3Item) && (Button1()))
                    {
                        activeReply1 = 9;
                        activeReply2 = 9;
                        activeReply3 = 0;
                    }
                    else if (isButton1Clicked)
                    {
                        activeReply1 = 0;
                        activeReply2 = 7;
                        activeReply3 = 0;
                    }
                    else if (isButton1Clicked)
                    {
                        activeReply1 = 0;
                        activeReply2 = 14;
                        activeReply3 = 0;
                    }

                    break;
                }
        
            case 7:
                {
                    if ((item.office2Item) && (Button2()))
                    {
                        activeReply1 = 9;
                        activeReply2 = 0;
                        ButtonReset();

                    }

                    else if (Button1())
                    {
                        activeReply1 = 8; //"Maybe you could take some time off?";
                        activeReply2 = 0;
                        activeReply3 = 0;

                    }
                    if (Button2())
                    {
                        activeReply1 = 0;
                        activeReply2 = 14;// "I have the same symptoms as you.  Maybe teach me the exercises too?";
                        activeReply3 = 0;

                    }
                    if (Button3())
                    {

                        activeReply1 = 0;
                        activeReply2 = 13; //"I have the same symptoms as you.  Can you teach me the exercises too?"
                        activeReply3 = 0;

                    }
                }
                break;
        
            case 8:
                {
                    actorMessageText.text = "Yeah, but who's gonna shoulder this load while I'm gone?  It's not that simple.";
                    {
                        if (Button1())
                        {
                            activeReply1 = 8; //"Maybe you could take some time off?";
                            activeReply2 = 0;
                            activeReply3 = 0;

                        }
                        if (Button2())
                        {
                            activeReply1 = 0;
                            activeReply2 = 14;// "I have the same symptoms as you.  Maybe teach me the exercises too?";
                            activeReply3 = 0;

                        }
                        if (Button3())
                        {

                            activeReply1 = 0;
                            activeReply2 = 13; //"I have the same symptoms as you.  Can you teach me the exercises too?"
                            activeReply3 = 0;

                        }

                        
                    }
                    break;
                }

            case 9:
                {
                    playerChoice1.text = "Thanks, Pal";
                    playerChoice2.text = "(No Comment)";
                    ButtonReset();
                    break;
                }
        }
        //bobSays.BobsReplies();
        
    }
}
