using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_Cadets : MonoBehaviour
{
    public GM gm;
    public Spawn_Cadets sc;
    [Space]
    public List<Cadets> listCadet = new List<Cadets>();
    public List<Complex�> cx = new List<Complex�>();

    [SerializeField] private GameObject warningText;

    [SerializeField] private Text nameInfo;
    [SerializeField] private Text expInfo;
    [SerializeField] private Text strengthInfo;
    [SerializeField] private Text agilityInfo;
    [SerializeField] private Text staminaInfo;
    [SerializeField] private Text intelligenceInfo;
    [SerializeField] private Text combatTrainingInfo;
    [SerializeField] private Text marchingInfo;
    [SerializeField] private Image spriteCadetInfo;
    [SerializeField] private Image spriteRankInfo;

    [SerializeField] private int indexCadet;

    public void CheckListCadets()
    {
        if (listCadet.Count == 0)
        {
            warningText.SetActive(true);

        }
        else { UpdateListCadets(); warningText.SetActive(false); }

    }

    public void UpdateListCadets()
    {
        if (listCadet.Count >= 1)
        {
            for (int i = 0; i < cx.Count; i++)
            {
                cx[i].button.SetActive(false);
            }
            for (int i = 0; i < listCadet.Count; i++)
            {
                cx[i].name.text = listCadet[i].name;
                cx[i].rank.text = listCadet[i].rank;
                cx[i].button.SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < cx.Count; i++)
            {
                cx[i].button.SetActive(false);
            }
            CheckListCadets();
        }


    }

    public void InfoCadet(int index)
    {
        nameInfo.text = listCadet[index].name;
        expInfo.text = listCadet[index].exp + "";
        strengthInfo.text = listCadet[index].strength + "";
        agilityInfo.text = listCadet[index].agility + "";
        staminaInfo.text = listCadet[index].stamina + "";
        intelligenceInfo.text = listCadet[index].intelligence + "";
        combatTrainingInfo.text = listCadet[index].combatTraining + "";
        marchingInfo.text = listCadet[index].marching + "";
        spriteCadetInfo.sprite = listCadet[index].spriteNPC;
        spriteRankInfo.sprite = listCadet[index].spriteRank;
        indexCadet = index;
        print(indexCadet + " " + listCadet[indexCadet].id);
        gm.SAH(2);
    }
    public void DeleteCadet()
    {
        gm.SAH(2);
        sc.DestroyPrefabCadet(listCadet[indexCadet].id);
        listCadet.RemoveAt(indexCadet);
        UpdateListCadets();
    }

}

[System.Serializable]
public class Cadets
{
    [Tooltip("����� ��� ������ �� �����")]
    public int id;
    [Tooltip("��� ��� ������")]
    public string name;

    [Tooltip("������ ��� ���")]
    public Sprite spriteNPC;

    [Tooltip("���������� �����")]
    public string rank;

    [Tooltip("������ �����")]
    public Sprite spriteRank;

    [Tooltip("EXP")]
    public int exp;

    [Tooltip("����")]
    public int strength;

    [Tooltip("��������")]
    public int agility;

    [Tooltip("������������")]
    public int stamina;

    [Tooltip("��������")]
    public int intelligence;

    [Tooltip("������ ����������")]
    public int combatTraining;

    [Tooltip("�������� ����������")]
    public int marching;



    public Cadets(int idC,string nameC, Sprite NPC, string rankC, Sprite spriteRankC, int expC, int strengthC, int agilityC, int staminaC, int intelligenceC, int combatTrainingC, int marchingC)
    {
        id = idC;
        name = nameC;
        spriteNPC = NPC;
        rank = rankC;
        spriteRank = spriteRankC;
        exp = expC;
        strength = strengthC;
        agility = agilityC;
        stamina = staminaC;
        intelligence = intelligenceC;
        combatTraining = combatTrainingC;
        marching = marchingC;

    }
}

[System.Serializable]

public class Complex�
{
    [Tooltip("����� ��� ����� ������")]
    public Text name;
    [Tooltip("����� ��� ����� ������")]
    public Text rank;
    [Tooltip("�������� ������")]
    public Image sprite;
    [Tooltip("������")]
    public GameObject button;

    public Complex�(Text nameC, Text rankC, Image spriteC, GameObject ButtonC)
    {
        name = nameC;
        rank = rankC;
        sprite = spriteC;
        button = ButtonC;
    }

}
