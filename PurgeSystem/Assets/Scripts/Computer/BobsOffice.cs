using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BobsOffice : MonoBehaviour
{
    public Slider off2Slider;
    private Player playerScript;
    private float counter;
    public bool downloadingComp0;
    public Image eUseImage;
    public Text EToUse;
    public string dialog;
    public bool ePressed;
    public bool bobsOfficeComputer;
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

        if (playerScript.useBobsComp == true)                   //if player presses e
        {
            off2Slider.gameObject.SetActive(true);      //show download bar
            eUseImage.gameObject.SetActive(false);      //deactivate popup box
            downloadingComp0 = true;                    //downloading from computer 2 is true
                                                        //activate UI and begin download
            off2Slider.gameObject.SetActive(true);      //show download bar
        }
        if (downloadingComp0)
        {
            counter += Time.deltaTime;
            off2Slider.value = counter;

            if (off2Slider.value >= off2Slider.maxValue)    //if download is complete
            {
                item.office0Item = true;
                eUseImage.gameObject.SetActive(true);       //popup box actviates
                off2Slider.gameObject.SetActive(false);     //Download bar deactivates
                EToUse.text = dialog;                       //display downloaded information
                playerScript.useBobsComp = false;
                downloadingComp0 = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bobsOfficeComputer = true;
            eUseImage.gameObject.SetActive(true);           //activate EtoUse Pop up box
            EToUse.text = "Press e to use";                 //Text = Press e to use
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bobsOfficeComputer = false;
            playerScript.useBobsComp = false;
            downloadingComp0 = false;
            eUseImage.gameObject.SetActive(false);
            //UI deactivates
            off2Slider.gameObject.SetActive(false);
        }
    }

    //make player press E to begin download
    //popup on ui with document received
}

