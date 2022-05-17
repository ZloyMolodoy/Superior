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
    public string rank;

    [Tooltip("������ �����")]
    public Sprite spriteRank;

    public cadets(string nameC, Sprite NPC, string rankC, Sprite spriteRankC)
    {
        name = nameC;
        spriteNPC = NPC;
        rank = rankC;
        spriteRank = spriteRankC;
    }
}
