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
    [Tooltip("Имя для кадета")]
    public string name;

    [Tooltip("Спрайт для НПС")]
    public Sprite spriteNPC;

    [Tooltip("Переменная ранга")]
    public string rank;

    [Tooltip("Спрайт ранга")]
    public Sprite spriteRank;

    public cadets(string nameC, Sprite NPC, string rankC, Sprite spriteRankC)
    {
        name = nameC;
        spriteNPC = NPC;
        rank = rankC;
        spriteRank = spriteRankC;
    }
}
