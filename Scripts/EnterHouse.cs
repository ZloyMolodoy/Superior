using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnterHouse : MonoBehaviour
{
    public int whatsHouse;

    public GM gm;

    public GameObject button_E;

    private void Start() 
    {
        button_E.SetActive(false);
    }

    private void OnTriggerEnter2D() {button_E.SetActive(true);}
    private void OnTriggerStay2D() 
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (whatsHouse)
            {
                case 0:
                    print("Staff");
                    gm.SAH(0);
                    break;
            }
        }
    }

    private void OnTriggerExit2D() {button_E.SetActive(false);}



}
