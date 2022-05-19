using System.Collections;
using UnityEngine;

public class GM : MonoBehaviour
{
    [Header("—сылки на скрипты")]
    public Control_Cadets cd;
    public Recruiting rg;
    [Space]
    [SerializeField] private GameObject statsPanel, staffPanel, recruitingPanel, InfoPanel;
    [Space]
    public Sprite privates, capral, sergant, superSergant, specialSergant, masterSergant, upperSergant;
    public Sprite Cadets;


    public int rep = 0;


    private void Start()
    {
        StartCoroutine(TimerUpdateCadets());
    }

    IEnumerator TimerUpdateCadets()
    {
        while (true)
        {
            rg.UpdateRG();
            yield return new WaitForSeconds(300); // 5 минут
        }
    }

    public void SAH(int index)
    {
        switch (index)
        {
            case 0:
                staffPanel.SetActive(!staffPanel.activeSelf);
                InfoPanel.SetActive(false);
                recruitingPanel.SetActive(false);
                cd.CheckListCadets();
                break;
            case 1:
                recruitingPanel.SetActive(!recruitingPanel.activeSelf);
                InfoPanel.SetActive(false);
                statsPanel.SetActive(false);
                staffPanel.SetActive(false);
                break;
            case 2:
                InfoPanel.SetActive(!InfoPanel.activeSelf);
                break;
            case 3:
                statsPanel.SetActive(!statsPanel.activeSelf);
                InfoPanel.SetActive(false);
                recruitingPanel.SetActive(false);
                staffPanel.SetActive(false);
                break;
        }
    }
}
