using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Menu_Controller : MonoBehaviour
{
    [SerializeField] private Text text, text1;

    private JsonFile _jsonFile;

    private string _path;

    private void Start() 
    {
        _path = Application.dataPath + "/" + "StreamingAssets" + "/" + "update.json";
        print(_path);
        _jsonFile = JsonUtility.FromJson<JsonFile>(File.ReadAllText(_path));


    }

}
[System.Serializable]
public class JsonFile 
{
    public string version;
    public string about;
}
