using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Office1 : MonoBehaviour
{
    public Slider off2Slider;
    private Player playerScript;
    private float counter;
    public bool downloadingComp1;
    public Image eUseImage;
    public Text EToUse;
    public string dialog;
    public bool ePressed;
    public bool OfficeComputer1;
    public InfoCollected item;

    private void Start()
    {
        off2Slider.value = 0;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        off2Slider.maxValue = 15;
    }
    // Update is called once per frame
    void Update()
    {
        ePressed = playerScript.useOffice2Comp;

        if (playerScript.useOffice1Comp == true)                   //if player presses e
        {
            off2Slider.gameObject.SetActive(true);      //show download bar
            eUseImage.gameObject.SetActive(false);      //deactivate popup box
            downloadingComp1 = true;                    //downloading from computer 1 is true
                                                        //activate UI and begin download
            off2Slider.gameObject.SetActive(true);      //show download bar
        }
        if (downloadingComp1)
        {
            counter += Time.deltaTime;
            off2Slider.value = counter;

            if (off2Slider.value >= off2Slider.maxValue)    //if download is complete
            {
                item.office2Item = true;
                eUseImage.gameObject.SetActive(true);       //popup box actviates
                off2Slider.gameObject.SetActive(false);     //Download bar deactivates
                EToUse.text = dialog;                       //display downloaded information
                playerScript.useOffice2Comp = false;
                downloadingComp1 = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OfficeComputer1 = true;
            eUseImage.gameObject.SetActive(true);           //activate EtoUse Pop up box
            EToUse.text = "Press e to use";                 //Text = Press e to use
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OfficeComputer1 = false;
            playerScript.useOffice1Comp = false;
            downloadingComp1 = false;
            eUseImage.gameObject.SetActive(false);
            //UI deactivates
            off2Slider.gameObject.SetActive(false);
        }
    }

    //make player press E to begin download--Done
    //popup on ui with document received--Done
}

