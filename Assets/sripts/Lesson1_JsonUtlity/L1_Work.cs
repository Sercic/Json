using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
[System.Serializable]
public class Item
{
    public int id;
    public int num;
    public Item(int id,int num)
    {
        this.id = id;
        this.num = num;
    }
}
public class PlayerInfo
{
    public string name;
    public int atk;
    public int def;
    public float moveSpeed;
    public double roundSpeed;
    public Item weapon;
    public List<int> listInt;
    public List<Item> itemList;
    [SerializeField]
    private int PrivateI = 1;
    [SerializeField]
    protected int protectedI = 2;

    //序列化对象
    public static void Savejson(PlayerInfo player,string jsonName)
    {
        string str = JsonUtility.ToJson(player);
        File.WriteAllText(Application.streamingAssetsPath+"/" + jsonName+".json", str);
    }

    //反序列化对象
    public static PlayerInfo Loadjson(string jsonName)
    {
        string str = File.ReadAllText(Application.streamingAssetsPath + "/" + jsonName + ".json");
        //PlayerInfo tempP = JsonUtility.FromJson<PlayerInfo>(str);
        //return tempP;
        return JsonUtility.FromJson<PlayerInfo>(str);
    }
}
public class L1_Work : MonoBehaviour
{
    private void Start()
    {
        PlayerInfo p = new PlayerInfo()
        {
            name = "名字",
            atk = 1,
            def = 1,
            moveSpeed = 1.2f,
            roundSpeed = 1.3f,
            weapon = null,
            listInt = new() { 1, 2, 3 },
            itemList = new List<Item> { new Item(1, 2), new Item(2, 3) },
        };
        PlayerInfo.Savejson(p, "Work");
        PlayerInfo p2 = PlayerInfo.Loadjson("Work");
        print(p2.atk);
       
    }
}
