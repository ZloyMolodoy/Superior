using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_Cadets : MonoBehaviour
{
    public GM gm;
    public List<cadets> listCadet = new List<cadets>();

    

}

[System.Serializable]
public class cadets 
{
    [Tooltip("��� ��� ������")]
    public string name;

    [Tooltip("������ ��� ���")]
    public Sprite spriteNPC;

    [Tooltip("���������� �����")]
    public int rank;

    [Tooltip("������ �����")]
    public Sprite spriteRank;
}
