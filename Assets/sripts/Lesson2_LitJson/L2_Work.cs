using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Item2
{
    public int id;
    public int num;
    public Item2() { }
    public Item2(int id, int num)
    {
        this.id = id;
        this.num = num;
    }
}
public class PlayerInfo2
{
    public string name;
    public int atk;
    public int def;
    public float moveSpeed;
    public double roundSpeed;
    public Item2 weapon;
    public List<int> listInt;
    public List<Item2> itemList;
    private int PrivateI = 1;
    protected int protectedI = 2;

    //序列化对象
    public static void Savejson(PlayerInfo2 player, string jsonName)
    {
        string str = JsonMapper.ToJson(player);
        File.WriteAllText(Application.streamingAssetsPath + "/" + jsonName + ".json", str);
    }

    //反序列化对象 
    public static PlayerInfo2 Loadjson(string jsonName)
    {
        string str = File.ReadAllText(Application.streamingAssetsPath + "/" + jsonName + ".json");
        //PlayerInfo tempP = JsonUtility.FromJson<PlayerInfo>(str);
        //return tempP;
        return JsonMapper.ToObject<PlayerInfo2>(str);
    }
}
public class L2_Work : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerInfo2 p = new PlayerInfo2()
        {
            name = "名字",
            atk = 1,
            def = 1,
            moveSpeed = 1.2f,
            roundSpeed = 1.3f,
            weapon = null,
            listInt = new() { 1, 2, 3 },
            itemList = new List<Item2> { new Item2(1, 2), new Item2(2, 3) }
        };
        PlayerInfo2.Savejson(p, "Work2");
        PlayerInfo2 p2 = PlayerInfo2.Loadjson("Work2");
        print(p2.atk);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
