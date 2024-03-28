using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RoleData
{
    public List<RoleInfo> list;
}

[Serializable]
public class RoleInfo
{
    public int hp;
    public string speed;
    public int volume;
    public string resName;
    public int scale;
}

[Serializable]
public class Student
{
    public int age = 11;
    public string name = "Student";
}
public class Mypeople
{
    public string name = "名字";
    public int age = 10;
    public bool sex = true;
    public float testF = 1.111f;
    public double testD = 1.222d;

    public int[] ids = { 1, 2, 3 };
    public List<int> ids2 = new List<int>{1,2,3};
    public Dictionary<int, string> dic = new() { { 1,"值"},{ 2,"值2"} };
    public Dictionary<string, string> dic2 = new() { { "键", "值" } ,{ "键1","值2" } };

    public Student s1 = null;
    public List<Student> s2s = new List<Student> { new Student()};

    [SerializeField]
    private int PrivateI = 1;
    [SerializeField]
    protected int ProtectedI = 2;
}

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 JsonUtlity是什么?
        //JsonUtlity 是Unity自带的用于解析Json的公共类
        //它可以
        //1.将内存中对象序列化为Json格式的字符串
        //2.将Json字符串反序列化为类对象
        #endregion

        #region 知识点二 必备知识点—在文中存读字符串
        //1.存储字符串到指定路径文件中
        //第一个参数 填写的是存储的路径
        //第二个参数 填写的是存储的字符串内容
        File.WriteAllText(Application.persistentDataPath + "/Json/Test.json", "我存储的json文件");
        print(Application.persistentDataPath);
        //注意:通过这样的方式进行存储,一定要保证路径文件是存在的,不然会报错

        //2.在指定路径文件中读取字符串
        string str = File.ReadAllText(Application.persistentDataPath + "/Json/Test.json");
        print(str);
        #endregion

        #region 知识点三 使用JsonUtlity进行序列化
        //序列化:把内存中的数据 存储到硬盘上
        //方法:
        //JsonUtlity.ToJson(对象)

        Mypeople t = new Mypeople();

        //Unity提供了现成的方法 可以把类对象 序列化为 json字符串
        string jsonString = JsonUtility.ToJson(t);
        File.WriteAllText(Application.persistentDataPath + "/MyPeople.json", jsonString);
        

        //注意:
        //1.float序列化时看起来会有一些误差
        //2.自定义类需要加上序列化特性[System.Serializable]
        //3.想要序列化私有变量 需要加上特性[SerializeField]
        //4.JsonUtlity不支持字典
        //5.JsonUtlity存储null对象不会是null 而是默认值的数据
        #endregion

        #region 知识点四 使用JsonUtlity进行反序列化
        //反序列化:把硬盘上的数据 读取到内存中
        //方法:
        //JsonUtlity.FromJson(字符串)
        //读取文件中的json字符串
        jsonString = File.ReadAllText(Application.persistentDataPath + "/MyPeople.json");
        //使用Json字符串内容 转换成类对象
        Mypeople t2 = JsonUtility.FromJson(jsonString,typeof(Mypeople)) as Mypeople;
        Mypeople t3 = JsonUtility.FromJson<Mypeople>(jsonString);

        //注意:
        //如果Json中数据少了,读取到内存中类对象时不会报错
        #endregion

        #region 知识点五 注意事项
        //1.JsonUtility无法直接读取数据集合
        jsonString = File.ReadAllText(Application.streamingAssetsPath + "/Roleinfo2.json");
        //print(jsonString);

        //这样是错误的
        //List<RoleInfo> roleInfoList = JsonUtility.FromJson<List<RoleInfo>>(jsonString);

        //用RoleData来包裹一层
        RoleData data = JsonUtility.FromJson<RoleData>(jsonString);
        //2.文本编码格式需要UTF-8 不然无法加载
        #endregion

        #region 总结
        //1.必备知识点 ——File存读字符串的方法:ReadAllText和WriteAllText   
        //2.JsonUtility提供的序列化方法 ToJson 和 FromJson
        //3.自定义类需要加上序列化特性[System.Serializable]
        //4.私有保护成员 需要加上[SerializeField]
        //5.JsonUtility不支持字典
        //6.JsonUtiity不能直接将数据反序列化为数据集合
        //7.Json文档编码格式必须是UTF-8

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
