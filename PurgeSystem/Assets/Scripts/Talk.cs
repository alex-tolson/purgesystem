using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{
    public Image eUseImage;
    public Text EToUse;
    public string dialog;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            eUseImage.gameObject.SetActive(true);
            EToUse.text = dialog;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        eUseImage.gameObject.SetActive(false);
    }
}