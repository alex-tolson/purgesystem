using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhilSays : MonoBehaviour
{
    public Text actorMessageText;
    public Text playerChoice1;
    public Text playerChoice2;
    public BobSays bobSays;
    public int activeReply1;
    public int activeReply2;
    public bool isButton1Clicked;
    public bool isButton2Clicked;
    public int activeBobsReply;
    public int activeMyChoice;
    public InfoCollected item;

    // Start is called before the first frame update
    void Start()
    {
        activeBobsReply = 0;
        activeMyChoice = 0;
        activeReply1 = 1;
        activeReply2 = 0;
        isButton1Clicked = false;
        isButton2Clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Button1ClickedCo()
    {
        isButton1Clicked = true;

        yield return new WaitForSecondsRealtime(.1f);

        isButton1Clicked = false;
    }

    public void Button1Clicked()
    {
        StartCoroutine(Button1ClickedCo());
    }


    IEnumerator Button2ClickedCo()
    {
        isButton2Clicked = true;

        yield return new WaitForSecondsRealtime(.1f);

        isButton2Clicked = false;
    }

    public void Button2Clicked()
    {
        StartCoroutine(Button2ClickedCo());
    }

    public void MyChoices()
    {
        switch (activeMyChoice)
        { 
            case 1:                                                    
                {
                    if (isButton1Clicked)
                    {
                        
                        activeReply1 = 2;                               //The Slick Willies ROCKED.  Nothing like a little smooth rock to kick off the weekend.
                        activeReply2 = 0;
                    }
                    if (isButton2Clicked)
                    {

                        activeReply1 = 0;
                        activeReply2 = 3;                              //It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality
                    }
                    break;
                }
            case 2:                                                   // The Slick Willies ROCKED.  Nothing like a little smooth rock to kick off the weekend.
                {
                    if (isButton1Clicked)
                    {
                        activeReply1 = 5;
                        activeReply2 = 0;
                    }
                    if (isButton2Clicked)
                    {
                        activeReply1 = 0;
                        activeReply2 = 6;
                    }

                    break;
                }
            case 3:                                                
                {
                    if (isButton1Clicked)
                    {
                        activeReply1 = 0;
                        activeReply2 = 4;

                    }

                    if ((item.office1Item) && (item.office2Item) && (item.office3Item) && (item.alexofficeItem) && (isButton1Clicked))
                    {
                        activeReply1 = 10;
                        activeReply2 = 0;
                        
                    }
                    else if (isButton2Clicked)
                        {
                            activeReply1 = 0;
                            activeReply2 = 8;

                        }

                    break;
                }

            case 4:                                                                                   
                {
                    //actorMessageText.text = "Yeah, but who's gonna shoulder this load while I'm gone?  It's not that simple.";


                    //playerChoice1.text = "I'm pretty sure I have the same symptoms as you.  Maybe you can teach me the exercises too?";

                    //playerChoice2.text = "I know something about yoga.  I can teach you a few moves.";

                    if ((item.office1Item) && ((isButton1Clicked) || (isButton2Clicked)))
                    {

                        //if (isButton1Clicked)
                        //{
                            activeReply1 = 9;
                        //    activeReply2 = 0;
                        //}
                        //else if (isButton2Clicked)
                        //{
                        //    activeReply1 = 0;
                            activeReply2 = 9;
                        
                        //}

                    }
                    else
                    {
                        if (isButton1Clicked)
                        {
                            activeReply1 = 14;
                            activeReply2 = 0;
                        }
                        if(isButton2Clicked)
                        {
                            activeReply1 = 0;
                            activeReply2 = 8;
                        }

                    }
                    break;
                }

            case 5:
                {
                    playerChoice1.text = "...";
                    playerChoice2.text = "...";
                    break;
                }
            case 6:
                {
                    if ((item.office3Item) && (isButton1Clicked))
                    {
                        activeReply1 = 9;
                        activeReply2 = 9;
                    }


                    else if (isButton1Clicked)
                    {
                        activeReply1 = 0;
                        activeReply2 = 8;
                    }
                    //else if (isButton2Clicked)
                    //{
                    //    activeReply1 = 0;
                    //    activeReply2 = 8;
                    //}

                    break;
                }
            case 7:
                {
                    playerChoice1.text = "I'm pretty sure I have the same symptoms as you.  Maybe you can teach me the exercises too?";

                    playerChoice2.text = "...";

                    {
                        if ((item.office2Item) && (isButton1Clicked))
                        {
                                activeReply1 = 9;
                                activeReply2 = 0;
                            
                        }
                        else
                        {
                            activeReply1 = 8;
                            activeReply2 = 0;
                        }
                    }
                    break;
                }
            case 8:
                {
                    playerChoice1.text = "...";
                    playerChoice2.text = "...";
                    break;
                }

            case 9:
                {
                    playerChoice1.text = "Thanks, Pal";

                    playerChoice2.text = "...";
                    break;
                }
        }
        bobSays.BobsReplies();
        
    }
}
