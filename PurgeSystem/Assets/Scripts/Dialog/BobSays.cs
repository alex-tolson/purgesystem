using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class BobSays : MonoBehaviour
{
    public bool isOpen = false;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI actorMessageText;
    public Image dialoguePanel;
    public PhilSays philSays;
    public int activeMyChoice;
    public NPC myNPC;


    public void BobsReplies()
    {
        switch (philSays.activeReply1)
        {
            case 1://"Hey Phil, did you want to talk to me?";
                {
                    Debug.Log("Phil Says: active reply1: 1");

                    actorMessageText.text = "Hey Phil, did you want to talk to me?";
                    actorName.text = "Bob";

                    philSays.activeMyChoice = 1;

                    philSays.playerChoice1.text = "How was the concert over the weekend?";

                    philSays.playerChoice2.text = "What'd the Doc say?";

                    philSays.playerChoice3.text = "How are you, this morning?";

                    break;
                }
            case 2://"How was the concert over the weekend?"
                {
                    Debug.Log("Phil Says: active reply1: 2");
                    philSays.activeMyChoice = 2;

                    actorName.text = "Bob";

                    actorMessageText.text = "The Slick Willies ROCKED. Nothing like easy listening to start the weekend.";

                    philSays.playerChoice1.text = "Too much partying?  What's the wife gonna think?";

                    philSays.playerChoice2.text = "Did you get your autograph?";

                    philSays.playerChoice3.text = "Maybe we can do a re-watch party at your place?";

                    break;
                }
            case 3://"What'd the Doc say?";
                {
                    Debug.Log("Phil Says: active reply1: 3");
                    philSays.activeMyChoice = 3;

                    actorName.text = "Bob";

                    actorMessageText.text = "It's atrophy from the stasis pod.  He gave me exercises for I'm in True Reality";

                    philSays.playerChoice1.text = "Maybe you could take some time off?";

                    philSays.playerChoice2.text = "Maybe teach me the exercises too?";

                    philSays.playerChoice3.text = "I know something about yoga.  I can teach you a few moves.";

                    break;
                }
            case 4://"How are you, this morning?"
                {
                    Debug.Log("Phil Says: active reply1: 4");
                    philSays.activeMyChoice = 4;

                    actorName.text = "Bob";

                    actorMessageText.text = "I slept like garbage.  Stayed up too late.  Ugh, my head!";

                    philSays.playerChoice1.text = "Too much partying?  What's the wife gonna think?";

                    philSays.playerChoice2.text = "I have a dermapatch for that?";

                    philSays.playerChoice3.text = "It's about time you got out and lived a little.";

                    break;
                }
            case 5://"Too much partying?  What's the wife gonna think?"
                {
                    Debug.Log("Phil Says: active reply1: 5");
                    philSays.activeMyChoice = 5;

                    actorName.text = "Bob";

                    actorMessageText.text = "Who, Kim? This was her idea!";

                    philSays.playerChoice1.text = "She's a good lady!";

                    philSays.playerChoice2.text = "Maybe we can do a re-watch party at your place?";

                    philSays.playerChoice3.text = "All work and no play makes Jack a dull boy";

                    break;
                }
            case 6://"Did you get your autograph?"
                {
                    Debug.Log("Phil Says: active reply1: 6");
                    philSays.activeMyChoice = 10;

                    actorName.text = "Bob";

                    actorMessageText.text = "Yeah, Wanna See?!";

                    philSays.playerChoice1.text = "Yes!  Look at that stage presence.";

                    philSays.playerChoice2.text = "Wish I had gone.";

                    philSays.playerChoice3.text = "Maybe we can do a re-watch party at your place?";

                    break;
                }

            case 7://"Maybe we can do a re-watch party at your place?";
                {
                    Debug.Log("Phil Says: active reply1: 7");
                    actorName.text = "Bob";

                    philSays.activeMyChoice = 0;
                    philSays.MyChoices();
                    actorMessageText.text = "Maybe another time...";

                    break;
                }


            case 8://"Maybe you could take some time off?";
                {
                    Debug.Log("Phil Says: active reply1: 8");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 8;


                    actorMessageText.text = "Who's gonna carry this workload while I'm gone?";

                    philSays.playerChoice1.text = "Can you teach me the exercises too?";

                    philSays.playerChoice2.text = "That's a fair point.";

                    philSays.playerChoice3.text = "If you and Kim need anything, I'll help out as I can.";


                    break;
                }

            case 9://Winner Response
                {
                    Debug.Log("Phil Says: active reply1: 9");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 9;

                    actorMessageText.text = "Sure, I'll give you my True Reality address.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }
            case 10://"Winner Response";
                {
                    Debug.Log("Phil Says: active reply1: 10");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 0;
                    actorMessageText.text = "Thanks.  Why don't you come over for dinner after work tonight?.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }

            case 11://"I have a dermapatch for that?";
                {
                    Debug.Log("Phil Says: active reply1: 11");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 0;
                    actorMessageText.text = "No thanks. I don't trust them and you shouldn't either.";
                    philSays.MyChoices();
                    break;
                }

            case 12://"It's about time you got out and lived a little.";
                {
                    Debug.Log("Phil Says: active reply1: 12");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 0;
                    actorMessageText.text = "I do have a life, ya know!";
                    philSays.MyChoices();
                    break;
                }
            case 14:
                {
                    Debug.Log("Phil Says: active reply1: 14");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 0;
                    actorMessageText.text = "You can probably find them online.";
                    philSays.MyChoices();
                    break;
                }
            default:
                {
                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }
        }

        switch (philSays.activeReply2)
        {
            case 1:
                {
                    Debug.Log("Phil Says: active reply2: 1 "); //She's a good lady
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 5;
                    actorMessageText.text = "Better than you.";
                    break;
                }
            case 2:
                {
                    Debug.Log("Phil Says: active reply2: 2 "); //you can probably find them online
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 0;
                    actorMessageText.text = "You can probably find them online...";
                    break;
                }
            case 4:
                {
                    Debug.Log("Phil Says: active reply2: 4");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 8;

                    actorMessageText.text = "Yeah, but who's gonna shoulder this load while I'm gone?";

                    philSays.playerChoice1.text = "Maybe you can teach me the exercises too?";

                    philSays.playerChoice2.text = "I know something of yoga.  I can teach you a few moves.";

                    philSays.playerChoice3.text = "I know a guy who knows a guy...";

                    break;
                }
            case 5:
                {
                    Debug.Log("Phil Says: active reply2: 5"); //All work and no play makes jack a dull boy
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";
                    actorMessageText.text = "Maybe so... but I AM the boss.";
                    break;
                }
            case 6:
                {
                    Debug.Log("Phil Says: active reply2: 6");
                    philSays.activeMyChoice = 6;
                    actorName.text = "Bob";

                    actorMessageText.text = "They digi-signed as a unique NonFungible Token!!!";

                    philSays.playerChoice1.text = "Since it was so good, wanna have a rewatch party?";

                    philSays.playerChoice2.text = "Look at that digital signature!";

                    philSays.playerChoice3.text = "It's about time you got out and lived a little!";

                    break;
                }
            case 7://"Did you get your autograph?"
                {
                    Debug.Log("Phil Says: active reply2: 7");
                    philSays.activeMyChoice = 7;

                    actorName.text = "Bob";

                    actorMessageText.text = "Yeah, Wanna See?!";

                    philSays.playerChoice1.text = "Yes!  Look at that stage presence.";

                    philSays.playerChoice2.text = "Wish I had gone.";

                    philSays.playerChoice3.text = "Maybe we can do a re-watch party at your place?"; 
                    break;
                }
            case 10:
                {
                    Debug.Log("Phil Says: active reply2: 10");
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";
                    actorMessageText.text = "Did you want to say something?";
                }
                break;
            case 11:
                {
                    Debug.Log("Phil Says: active reply2: 11");
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";
                    actorMessageText.text = "I don't fraternize with subordinates.";
                }
                break;
            case 12:
                {
                    Debug.Log("Phil Says: active reply2: 12");
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";

                    actorMessageText.text = "Humph...";
                }
                break;
            case 13:
                {
                    Debug.Log("Phil Says: active reply2: 13");
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";

                    actorMessageText.text = "Thanks for the offer.  I may take you up on it.";
                    //offer bonus if 1/3 is missing, auto complete that information:
                }
                break;
            case 14:
                {
                    Debug.Log("Phil Says: active reply2: 14");
                    philSays.activeMyChoice = 0;
                    actorName.text = "Bob";

                    actorMessageText.text = "All work and no play makes Jack a dull boy.";                    
                }
                break;
        }

    }
}
