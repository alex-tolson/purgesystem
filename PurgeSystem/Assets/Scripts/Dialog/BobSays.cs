using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Text actorName;
    public Text actorMessageText;
    //public Text buttonChoice1;
    //public Text buttonChoice2;
    //public Player playerScript;
    public Image dialoguePanel;
    public PhilSays philSays;
    public int activeMyChoice;
    public NPC myNPC;
    //public InfoCollected item;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void BobsReplies()
    {
        switch (philSays.activeReply1)
        {
            case 1:
                {
                    Debug.Log("running 2");

                    actorMessageText.text = "Hey Phil, did you want to talk to me";
                    actorName.text = "Bob";

                    philSays.activeMyChoice = 1;

                    philSays.playerChoice1.text = "How was the concert over the weekend?";

                    philSays.playerChoice2.text = "What'd the Doc say?";

                    break;
                }
            case 2:
                {
                    philSays.activeMyChoice = 2;

                    actorName.text = "Bob";

                    actorMessageText.text = "The Slick Willies ROCKED.Nothing like a little smooth rock to kick off the weekend.";

                    philSays.playerChoice1.text = "Too much partying?  What's the wife gonna think?";

                    philSays.playerChoice2.text = "Did you get your autograph?";

                    break;
                }
            case 5:
                {
                    actorName.text = "Bob";

                    philSays.activeMyChoice = 5;

                    actorMessageText.text = "Who, Kim? This was her Idea!";

                    philSays.playerChoice1.text = "...";
                    philSays.playerChoice2.text = "...";

                    break;
                }


            //case 7:    
            //    {
            //        actorName.text = "Bob";
            //        philSays.activeMyChoice = 7;

            //        actorMessageText.text = "Yeah, but who's gonna carry this workload while I'm gone?  It's not that simple.";

            //        philSays.playerChoice1.text = "I'm pretty sure I have the same symptoms as you.  Maybe you can teach me the exercises too?";

            //        philSays.playerChoice2.text = "...";


            //        break;
            //    }

            case 9:
                {
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 9;
             
                    actorMessageText.text = "Sure, I'll give you my True Reality address.";

                    philSays.playerChoice1.text = "Thanks, Pal";
                    myNPC.ShowNext();
                    philSays.playerChoice2.text = "....";
                    break;
                }
            case 10:
                {
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 9;

                    actorMessageText.text = "Thanks.  Why don't you come over for dinner after work tonight?.";

                    philSays.playerChoice1.text = "Thanks, Pal";
                    myNPC.ShowNext();
                    philSays.playerChoice2.text = "...";
                    break;
                }

            case 14:
                {
                    actorName.text = "Bob";
                    activeMyChoice = 8;
                    actorMessageText.text = "You can probably find them online.";

                    philSays.playerChoice1.text = "...";
                    philSays.playerChoice2.text = "...";

                    break;
                }
        }

        switch (philSays.activeReply2)
        {

            case 3:
                {
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 3;

                    actorMessageText.text = "It's just some atrophy from the stasis pod.  He gave me some exercises to do when I'm in True Reality";

                    philSays.playerChoice1.text = "Have you thought about taking some time off work?";

                    philSays.playerChoice2.text = "If you and Kim need anything?  Let me know.";

                    break;
                }
            case 4:
                {
                    actorName.text = "Bob";
                    philSays.activeMyChoice = 4;

                    actorMessageText.text = "Yeah, but who's gonna shoulder this load while I'm gone?  It's not that simple.";

                    philSays.playerChoice1.text = "I'm pretty sure I have the same symptoms as you.  Maybe you can teach me the exercises too?";

                    philSays.playerChoice2.text = "I know something about yoga.  I can teach you a few moves.";

                    break;
                }

            case 6: 
                {
                    philSays.activeMyChoice = 6;
                    actorName.text = "Bob";

                    actorMessageText.text = "Yeah, they signed it as a one of kind NonFungible Token!!!";

                    philSays.playerChoice1.text = "Since it was so good the first time, maybe we can have a rewatch party?";
                    
                    philSays.playerChoice2.text = "...";

                    break;
                }

            case 8:   
                {
                    philSays.activeMyChoice = 8;
                    actorName.text = "Bob";

                    actorMessageText.text = "Uh, Maybe some other time.";

                    philSays.playerChoice1.text = "...";
                    philSays.playerChoice2.text = "...";

                    break;
                }
        }
    }
}
