using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    [Header("—сылки на скрипты")]
    public Control_Cadets cd;
    public Recruiting rg;
    [Space]
    [SerializeField] private GameObject staffPanel, recruitingPanel;
    [Space]
    public Sprite privates, capral, sergant, superSergant, specialSergant, masterSergant, upperSergant;
    public Sprite Cadets;


    public int rep;

    public void SAH(int index) 
    {
        switch (index) 
        {
            case 0:
                staffPanel.SetActive(!staffPanel.activeSelf);
                break;
            case 1:
                recruitingPanel.SetActive(!recruitingPanel.activeSelf);
                rg.updateRG();
                break;
        }
    }
}
