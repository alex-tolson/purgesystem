using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BobSays : MonoBehaviour
{
    //Message[] currentMessages;
    //Response[] currentResponses;
    //Actor[] currentActors;
    
    //public int activeReply1;
    //public int activeReply2;
    //public bool isButton1Clicked;
    //public bool isButton2Clicked;
    public bool isOpen = false;
    public TextMeshProUGUI actorName;
    public TextMeshProUGUI actorMessageText;
    //public Text buttonChoice1;
    //public Text buttonChoice2;
    //public Player playerScript;
    public Image dialoguePanel;
    public PhilSays philSays;
    public int activeMyChoice;
    public NPC myNPC;
    //public InfoCollected item;


    public void BobsReplies()
    {
        switch (philSays.activeReply1)
        {
            case 1://"Hey Phil, did you want to talk to me?";
                {
                    Debug.Log("Phil Says: active reply 1");

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
                    Debug.Log("Phil Says: active reply 2");
                    philSays.activeMyChoice = 2; 

                    actorName.text = "Bob";

                    actorMessageText.text = "The Slick Willies ROCKED. Nothing like a little easy listening to kick off the weekend.";

                    philSays.playerChoice1.text = "Too much partying?  What's the wife gonna think?";

                    philSays.playerChoice2.text = "Did you get your autograph?";

                    philSays.playerChoice3.text = "Maybe we can do a re-watch party at your place?";

                    break;
                }
            case 3://"What'd the Doc say?";
                {
                    Debug.Log("Phil Says: active reply 3");
                    philSays.activeMyChoice = 3;

                    actorName.text = "Bob"; 

                    actorMessageText.text = "It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality";

                    philSays.playerChoice1.text = "Maybe you could take some time off?";

                    philSays.playerChoice2.text = "I have the same symptoms as you.  Maybe teach me the exercises too?";

                    philSays.playerChoice3.text = "I know something about yoga.  I can teach you a few moves.";

                    break;
                }
            case 4://"How are you, this morning?"
                {
                    Debug.Log("Phil Says: active reply 4");
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
                    Debug.Log("Phil Says: active reply 5");
                    philSays.activeMyChoice = 5; 

                    actorName.text = "Bob";

                    actorMessageText.text = "Who, Kim? This was her idea!";

                    philSays.playerChoice1.text = "Too much partying?  What's the wife gonna think?";

                    philSays.playerChoice2.text = "Maybe we can do a re-watch party at your place?";

                    philSays.playerChoice3.text = "All work and no play makes Jack a dull boy";

                    break;
                }
            case 6://"Did you get your autograph?"
                {
                    Debug.Log("Phil Says: active reply 6");
                    philSays.activeMyChoice = 6; 

                    actorName.text = "Bob";

                    actorMessageText.text = "Yeah, Wanna See?!";

                    philSays.playerChoice1.text = "Yes!  Look at that stage presence.";

                    philSays.playerChoice2.text = "Wish I had gone.";

                    philSays.playerChoice3.text = "Maybe we can do a re-watch party at your place?";

                    break;
                }

            case 7://"Maybe we can do a re-watch party at your place?";
                {
                    Debug.Log("Phil Says: active reply 7");
                    actorName.text = "Bob";

                    philSays.activeMyChoice = 7; 

                    actorMessageText.text = "Maybe another time...";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";

                    break;
                }


            case 8://"Maybe you could take some time off?";
                {
                    Debug.Log("Phil Says: active reply 8");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 8; 


                    actorMessageText.text = "Who's gonna carry this workload while I'm gone? It's not that simple of a solution.";

                    philSays.playerChoice1.text = "I have the same symptoms as you.  Can you teach me the exercises too?";

                    philSays.playerChoice2.text = "That's a fair point.";
                    
                    philSays.playerChoice3.text = "(No Comment)";


                    break;
                }

            case 9://Winner Response
                {
                    Debug.Log("Phil Says: active reply 9");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 9; 

                    actorMessageText.text = "Sure, I'll give you my True Reality address.";

                    philSays.playerChoice1.text = "Thanks, Pal.  See ya tonight.";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }
            case 10://"Winner Response";
                {
                    Debug.Log("Phil Says: active reply 10");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 10;
                    actorMessageText.text = "Thanks.  Why don't you come over for dinner after work tonight?.";

                    philSays.playerChoice1.text = "Thanks, Pal.  See ya tonight.";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }

            case 11://"I have a dermapatch for that?";
                {
                    Debug.Log("Phil Says: active reply 11");
                    actorName.text = "Bob";    
                    philSays.activeMyChoice = 10;
                    actorMessageText.text = "No thanks. I don't trust them and you shouldn't either.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }

            case 12://"It's about time you got out and lived a little.";
                {
                    Debug.Log("Phil Says: active reply 12");
                    actorName.text = "Bob";  
                    philSays.activeMyChoice = 10; 
                    actorMessageText.text = "I do have a life, ya know!";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";
                    break;
                }
            case 13://"I have the same symptoms as you.  Can you teach me the exercises too?"
                {
                    Debug.Log("Phil Says: active reply 13");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 10;
                    actorMessageText.text = "You can probably find them on a wiki online.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                   philSays.playerChoice3.text = "(no comment)";
                    break;
                }
            case 14:
                {
                    Debug.Log("Phil Says: active reply 14");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 14;
                    actorMessageText.text = "You can probably find them online.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";

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

            case 3:
                {
                    Debug.Log("Phil Says: active reply2: 3");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 3;

                    actorMessageText.text = "It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality";

                    philSays.playerChoice1.text = "Have you thought about taking some time off work?";

                    philSays.playerChoice2.text = "If you and Kim need anything?  Let me know.";

                    philSays.playerChoice3.text = "Well, I hope you get better soon. You're invaluable.  You know?";

                    break;
                }
            case 4:
                {
                    Debug.Log("Phil Says: active reply2: 4");
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 4;

                    actorMessageText.text = "Yeah, but who's gonna shoulder this load while I'm gone?  It's not that simple.";

                    philSays.playerChoice1.text = "I'm pretty sure I have the same symptoms as you.  Maybe you can teach me the exercises too?";

                    philSays.playerChoice2.text = "I know something about yoga.  I can teach you a few moves.";
                    
                    philSays.playerChoice3.text = "(no comment)";

                    break;
                }

            case 6: 
                {
                    Debug.Log("Phil Says: active reply2: 6");
                    philSays.activeMyChoice = 6;
                    actorName.text = "Bob";

                    actorMessageText.text = "Yeah, they signed it as a one of kind NonFungible Token!!!";

                    philSays.playerChoice1.text = "Since it was so good the first time, maybe we can have a rewatch party?";
                    
                    philSays.playerChoice2.text = "Look at that digital signature!";

                    philSays.playerChoice3.text = "It's about time you got out and lived a little!";

                    break;
                }

            case 8:   
                {
                    Debug.Log("Phil Says: active reply2: 8");
                    philSays.activeMyChoice = 8;
                    actorName.text = "Bob";

                    actorMessageText.text = "Uh, Maybe some other time.";

                    philSays.playerChoice1.text = "(no comment)";
                    philSays.playerChoice2.text = "(no comment)";
                    philSays.playerChoice3.text = "(no comment)";

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
    }
}
