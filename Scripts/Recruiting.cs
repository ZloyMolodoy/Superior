using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recruiting : MonoBehaviour
{
    public GM gm;

    public List<RGcadets> listCadet = new List<RGcadets>();
    public List<Complex> cx = new List<Complex>();
    [Space]

    private int idV;
    private string nameV;
    private string rankV;
    private Sprite rankSV;
    private int expV;
    private int strengthV;
    private int agilityV;
    private int staminaV;
    private int intelligenceV;
    private int combatTrainingV;
    private int marchingV;
    public void UpdateRG()
    {

        if (listCadet.Count == 9)
        {
            PlusToRG();
        }
        else { print("ERROR, Recruiting script, element cadets"); }

    }

    public void PlusToRG()
    {

        for (int index = 0; index < listCadet.Count; index++)
        {
            RandomazeCadets(1);
            RandomazeCadets(2);
            RandomazeCadets(3);
            //listCadet[index].id = idV;
            listCadet[index].name = nameV;
            listCadet[index].spriteNPC = gm.Cadets;
            listCadet[index].rank = rankV;
            listCadet[index].spriteRank = rankSV;
            listCadet[index].exp = expV;
            listCadet[index].strength = strengthV;
            listCadet[index].agility = agilityV;
            listCadet[index].stamina = staminaV;
            listCadet[index].intelligence = intelligenceV;
            listCadet[index].combatTraining = combatTrainingV;
            listCadet[index].marching = marchingV;
            cx[index].name.text = listCadet[index].name;
            cx[index].rank.text = listCadet[index].rank;
        }
    }


    public void BuyingCadet(int index)
    {
        gm.cd.listCadet.Add(new Cadets(listCadet[index].id, listCadet[index].name, listCadet[index].spriteNPC, listCadet[index].rank, listCadet[index].spriteRank, listCadet[index].exp, listCadet[index].strength, listCadet[index].agility, listCadet[index].stamina, listCadet[index].intelligence, listCadet[index].combatTraining, listCadet[index].marching));

        gm.cd.sc.SpawnCadets(index);

        RandomazeCadets(1);
        RandomazeCadets(2);
        RandomazeCadets(3);
        //listCadet[index].id = idV;
        listCadet[index].name = nameV;
        listCadet[index].spriteNPC = gm.Cadets;
        listCadet[index].rank = rankV;
        listCadet[index].spriteRank = rankSV;
        listCadet[index].exp = expV;
        listCadet[index].strength = strengthV;
        listCadet[index].agility = agilityV;
        listCadet[index].stamina = staminaV;
        listCadet[index].intelligence = intelligenceV;
        listCadet[index].combatTraining = combatTrainingV;
        listCadet[index].marching = marchingV;
        cx[index].name.text = listCadet[index].name;
        cx[index].rank.text = listCadet[index].rank;
    }



    public void RandomazeCadets(int index)
    {
        //idV = Random.Range(1000000, 9999999);
        switch (index)
        {
            case 1: //Name
                int n1;
                n1 = Random.Range(1, 44);
                switch (n1)
                {
                    case 1:
                        nameV = "Jack Holand";
                        break;
                    case 2:
                        nameV = "Winslow Tomson";
                        break;
                    case 3:
                        nameV = "Jeff Manson";
                        break;
                    case 4:
                        nameV = "Tom Jeferson";
                        break;
                    case 5:
                        nameV = "Clark Davidson";
                        break;
                    case 6:
                        nameV = "Ethan Smith";
                        break;
                    case 7:
                        nameV = "Adam  Morris";
                        break;
                    case 8:
                        nameV = "Austen Lewis";
                        break;
                    case 9:
                        nameV = "Brian Patterson";
                        break;
                    case 10:
                        nameV = "Christopher Clark";
                        break;
                    case 11:
                        nameV = "Gary Rivera";
                        break;
                    case 12:
                        nameV = "Jonathan Medina";
                        break;
                    case 13:
                        nameV = "Harold Scott";
                        break;
                    case 14:
                        nameV = "Timothy Martinez";
                        break;
                    case 15:
                        nameV = "Donald Moran";
                        break;
                    case 16:
                        nameV = "David Hayes";
                        break;
                    case 17:
                        nameV = "Victor Johnson";
                        break;
                    case 18:
                        nameV = "Charles Gutierrez";
                        break;
                    case 19:
                        nameV = "Thomas Ramirez";
                        break;
                    case 20:
                        nameV = "Christopher Cross";
                        break;
                    case 21:
                        nameV = "Artem Kunavin";
                        break;
                    case 22:
                        nameV = "Daniel Griffin";
                        break;
                    case 23:
                        nameV = "Wayne Cox";
                        break;
                    case 24:
                        nameV = "Raymond Fox";
                        break;
                    case 25:
                        nameV = "Curtis Brooks";
                        break;
                    case 26:
                        nameV = "Robert Jenkins";
                        break;
                    case 27:
                        nameV = "Brian White";
                        break;
                    case 28:
                        nameV = "Ronald McGee";
                        break;
                    case 29:
                        nameV = "Robert Stephens";
                        break;
                    case 30:
                        nameV = "Antonio Meyer";
                        break;
                    case 31:
                        nameV = "Stanley Smith";
                        break;
                    case 32:
                        nameV = "Joseph Leonard";
                        break;
                    case 33:
                        nameV = "Christopher Cross";
                        break;
                    case 34:
                        nameV = "Artem Kunavin";
                        break;
                    case 35:
                        nameV = "Daniel Griffin";
                        break;
                    case 36:
                        nameV = "Wayne Cox";
                        break;
                    case 37:
                        nameV = "Raymond Fox";
                        break;
                    case 38:
                        nameV = "Curtis Brooks";
                        break;
                    case 39:
                        nameV = "Robert Jenkins";
                        break;
                    case 40:
                        nameV = "Brian White";
                        break;
                    case 42:
                        nameV = "Ronald McGee";
                        break;
                    case 43:
                        nameV = "Robert Stephens";
                        break;
                    case 44:
                        nameV = "Antonio Meyer";
                        break;
                }
                break;
            case 2:
                int h;
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        strengthV = h;
                        break;
                    case 2:
                        strengthV = h;
                        break;
                    case 3:
                        strengthV = h;
                        break;
                    case 4:
                        strengthV = h;
                        break;
                    case 5:
                        strengthV = h;
                        break;

                }
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        agilityV = h;
                        break;
                    case 2:
                        agilityV = h;
                        break;
                    case 3:
                        agilityV = h;
                        break;
                    case 4:
                        agilityV = h;
                        break;
                    case 5:
                        agilityV = h;
                        break;

                }
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        staminaV = h;
                        break;
                    case 2:
                        staminaV = h;
                        break;
                    case 3:
                        staminaV = h;
                        break;
                    case 4:
                        staminaV = h;
                        break;
                    case 5:
                        staminaV = h;
                        break;

                }
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        intelligenceV = h;
                        break;
                    case 2:
                        intelligenceV = h;
                        break;
                    case 3:
                        intelligenceV = h;
                        break;
                    case 4:
                        intelligenceV = h;
                        break;
                    case 5:
                        intelligenceV = h;
                        break;

                }
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        combatTrainingV = h;
                        break;
                    case 2:
                        combatTrainingV = h;
                        break;
                    case 3:
                        combatTrainingV = h;
                        break;
                    case 4:
                        combatTrainingV = h;
                        break;
                    case 5:
                        combatTrainingV = h;
                        break;

                }
                h = Random.Range(1, 5);
                switch (h)
                {
                    case 1:
                        marchingV = h;
                        break;
                    case 2:
                        marchingV = h;
                        break;
                    case 3:
                        marchingV = h;
                        break;
                    case 4:
                        marchingV = h;
                        break;
                    case 5:
                        marchingV = h;
                        break;

                }
                break;

            case 3: //int rank & sprite rank

                int r;
                r = Random.Range(1, 5500);
                float procent;
                float costR;
                if (gm.rep <= 30) { costR = r; procent = 30f; costR /= 100; costR *= procent; int costRP = Mathf.RoundToInt(costR); r = costRP; }
                else if (gm.rep > 30 && gm.rep <= 50) { costR = r; procent = 50f; costR /= 100; costR *= procent; int costRP = Mathf.RoundToInt(costR); r = costRP; }
                else if (gm.rep > 50 && gm.rep <= 80) { costR = r; procent = 70f; costR /= 100; costR *= procent; int costRP = Mathf.RoundToInt(costR); r = costRP; }
                if (r <= 200)
                {
                    rankV = "Private";
                    rankSV = gm.privates;
                    expV = r;
                    if (strengthV > 2) { strengthV = 2; }
                    if (agilityV > 2) { agilityV = 2; }
                    if (staminaV > 2) { staminaV = 2; }
                    if (intelligenceV > 3) { intelligenceV = 3; }
                    if (combatTrainingV > 2) { combatTrainingV = 2; }
                    if (marchingV > 3) { marchingV = 3; }
                }
                else if (r > 200 && r <= 700)
                {
                    rankV = "Capral";
                    rankSV = gm.capral;
                    expV = r;
                    if (strengthV > 2) { strengthV = 2; }
                    if (agilityV > 2) { agilityV = 2; }
                    if (staminaV > 2) { staminaV = 2; }
                    if (intelligenceV > 3) { intelligenceV = 3; }
                    if (combatTrainingV > 3) { combatTrainingV = 3; }
                    if (marchingV > 3) { marchingV = 3; }
                }
                else if (r > 700 && r <= 1300)
                {
                    rankV = "Sergant";
                    rankSV = gm.sergant;
                    expV = r;
                    if (strengthV > 3) { strengthV = 3; }
                    if (agilityV > 3) { agilityV = 3; }
                    if (staminaV > 3) { staminaV = 3; }
                    if (intelligenceV > 3) { intelligenceV = 3; }
                    if (combatTrainingV > 2) { combatTrainingV = 2; }
                    if (marchingV > 3) { marchingV = 3; }
                }
                else if (r > 1300 && r <= 2000)
                {
                    rankV = "Super Sergant";
                    rankSV = gm.superSergant;
                    expV = r;
                    if (strengthV > 3) { strengthV = 3; }
                    if (agilityV > 3) { agilityV = 3; }
                    if (staminaV > 3) { staminaV = 3; }
                    if (intelligenceV > 3) { intelligenceV = 3; }
                    if (combatTrainingV > 3) { combatTrainingV = 3; }
                    if (marchingV > 3) { marchingV = 3; }
                }
                else if (r > 2000 && r <= 3000)
                {
                    rankV = "Special Sergant";
                    rankSV = gm.specialSergant;
                    expV = r;
                    if (strengthV > 3) { strengthV = 3; }
                    if (agilityV > 3) { agilityV = 3; }
                    if (staminaV > 3) { staminaV = 3; }
                    if (intelligenceV > 4) { intelligenceV = 4; }
                    if (combatTrainingV > 4) { combatTrainingV = 4; }
                    if (marchingV > 3) { marchingV = 3; }
                }
                else if (r > 3000 && r <= 4100)
                {
                    rankV = "Master Sergant";
                    rankSV = gm.masterSergant;
                    expV = r;
                    if (strengthV > 4) { strengthV = 4; }
                    if (agilityV > 4) { agilityV = 4; }
                    if (staminaV > 4) { staminaV = 4; }
                    if (intelligenceV > 4) { intelligenceV = 4; }
                    if (combatTrainingV > 4) { combatTrainingV = 4; }
                    if (marchingV > 4) { marchingV = 4; }
                }
                else if (r > 4100)
                {
                    rankV = "Upper Sergant";
                    rankSV = gm.upperSergant;
                    expV = r;
                }
                break;

        }

    }


}

[System.Serializable]
public class RGcadets
{
    [Tooltip("Для поиска по карте")]
    public int id;
    [Tooltip("Имя для кадета")]
    public string name;

    [Tooltip("Спрайт для НПС")]
    public Sprite spriteNPC;

    [Tooltip("Переменная ранга")]
    public string rank;

    [Tooltip("Спрайт ранга")]
    public Sprite spriteRank;

    [Tooltip("EXP")]
    public int exp;

    [Tooltip("Сила")]
    public int strength;

    [Tooltip("Ловкость")]
    public int agility;

    [Tooltip("Выносливость")]
    public int stamina;

    [Tooltip("Интелект")]
    public int intelligence;

    [Tooltip("Боевая подготовка")]
    public int combatTraining;

    [Tooltip("Строевая подготовка")]
    public int marching;




    public RGcadets(int idC, string nameC, Sprite NPC, string rankC, Sprite spriteRankC, int expC, int strengthC, int agilityC, int staminaC, int intelligenceC, int combatTrainingC, int marchingC)
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

public class Complex
{
    [Tooltip("Текст для имени кадета")]
    public Text name;
    [Tooltip("Текст для ранга кадета")]
    public Text rank;
    [Tooltip("Картинка кадета")]
    public Image sprite;

    public Complex(Text nameC, Text rankC, Image spriteC)
    {
        name = nameC;
        rank = rankC;
        sprite = spriteC;
    }

}

