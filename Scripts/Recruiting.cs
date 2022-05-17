using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recruiting : MonoBehaviour
{
    public GM gm;

    public List<RGcadets> listCadet = new List<RGcadets>();
    public List<Complex> cx = new List<Complex>();
    [Space]
    


    private string nameV;
    private string rankV;
    private Sprite rankSV;






    public void updateRG() 
    {

        if (listCadet.Count == 9) 
        {
            PlusToRG();
        }
        else { print("ERROR, Recruiting script, element cadets"); }
    
    }


    public void PlusToRG() 
    {

        for(int i = 0; i < listCadet.Count; i++) 
        {
            RandomazeCadets(1);
            RandomazeCadets(3);
            listCadet[i].name = nameV;
            listCadet[i].spriteNPC = gm.Cadets;
            listCadet[i].rank = rankV;
            listCadet[i].spriteRank = rankSV;
            //listCadet.Add(new RGcadets(nameV, gm.Cadets, rankV, rankSV));
            cx[i].name.text = listCadet[i].name;
            cx[i].rank.text = listCadet[i].rank;
        }
    }


    public void BuyingCadet(int index) 
    {
    
    
    
    }


    //list2.AddRange(list1.ToArray());

    public void RandomazeCadets(int index) 
    {
        switch (index) 
        {
            case 1: //Name
                int n1;
                n1 = Random.Range(1, 20);
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
                    }
            break;

            case 3: //int rank & sprite rank

                int r;
                r = Random.Range(1, 7);

                switch (r) { 
                    case 1:
                    rankV = "Private";
                    rankSV = gm.privates;

                    break;
                    case 2:
                        rankV = "Capral";
                        rankSV = gm.capral;
                        break;
                    case 3:
                        rankV = "Sergant";
                        rankSV = gm.sergant;
                        break;
                    case 4:
                        rankV = "Super Sergant";
                        rankSV = gm.superSergant;
                        break;
                    case 5:
                        rankV = "Special Sergant";
                        rankSV = gm.specialSergant;
                        break;
                    case 6:
                        rankV = "Master Sergant";
                        rankSV = gm.masterSergant;
                        break;
                    case 7:
                        rankV = "UpperSergant";
                        rankSV = gm.upperSergant;
                        break;
                }
            break;
            
        }
    
    }


}

[System.Serializable]
public class RGcadets
{
     
    [Tooltip("Имя для кадета")]
    public string name;

    [Tooltip("Спрайт для НПС")]
    public Sprite spriteNPC;

    [Tooltip("Переменная ранга")]
    public string rank;

    [Tooltip("Спрайт ранга")]
    public Sprite spriteRank;



    public RGcadets(string nameC, Sprite NPC, string rankC, Sprite spriteRankC)
    {
        name = nameC;
        spriteNPC = NPC;
        rank = rankC;
        spriteRank = spriteRankC;
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

