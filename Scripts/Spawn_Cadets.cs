using UnityEngine;

public class Spawn_Cadets : MonoBehaviour
{
    public Control_Cadets cd;
    [Space]
    private float posX;
    private float posY;
    public GameObject Cadet;
    private int id;



    public void SpawnCadets(int index)
    {
        //print(ID);
        posX = Random.Range(-14, 24);
        posY = Random.Range(-11, 14);
        Instantiate<GameObject>(Cadet, new Vector2(posX, posY), Quaternion.identity);
        id = Random.Range(1000000, 9999999);
        Cadet.name = "Cadet" + id;
        cd.listCadet[index].id = id;

    }

    public void DestroyPrefabCadet(int ID) => Destroy(GameObject.Find("Cadet" + ID + "(Clone)"));

}
