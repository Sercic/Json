using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Student2
{
    public int age = 11;
    public string name = "Student";

    public Student2() { }
    public Student2(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
}
public class Mypeople2
{
    public string name = "名字";
    public int age = 10;
    public bool sex = true;
    public float testF = 1.111f;
    public double testD = 1.222d;

    public int[] ids = { 1, 2, 3 };
    public List<int> ids2 = new List<int> { 1, 2, 3 };
    //public Dictionary<int, string> dic = new() { { 1, "值" }, { 2, "值2" } };
    public Dictionary<string, string> dic2 = new() { { "键", "值" }, { "键1", "值2" } };

    public Student s1 = null;
    public List<Student> s2s = new List<Student> { new Student() };

    private int PrivateI = 1;
    protected int ProtectedI = 2;
}
public class RoleInfo2
{
    public int hp;
    public int speed;
    public int volume;
    public string resName;
    public int scale;
}
public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 LitJson是什么
        //它是一个第三方库,用于处理Json的序列化和反序列化
        //Litjson是C#编写的,体积小,速度快,易于使用
        //它可以很容易的嵌入到我们的代码中
        //只需要将ListJson代码拷贝到工程中即可
        #endregion

        #region 知识点二 获取LitJson
        //1.前往ListJson官网
        //2.通过官网前往Github获取最新你版本
        //3.将代码拷贝到Unity工程中 即可开始使用LitJson
        #endregion

        #region 知识点三 使用LitJson进行序列化
        //方法:
        //JsonMapper.ToJson(对象)
        Mypeople2 t = new Mypeople2();

        string json = JsonMapper.ToJson(t);
        print(Application.streamingAssetsPath);
        File.WriteAllText(Application.streamingAssetsPath + "/Litjson.json", json);
        //
        //注意:
        //1.相对JsonUtiliyt不需要加特性
        //2.不能序列化私有变量
        //3.支持字典类型
        //4.需要引用LitJson命名空间
        //5.LitJson可以准确的保存null类型
        #endregion

        #region 知识点四 使用LitJson反序列化
        //方法:
        //JsonMapper.ToObject(字符串)
        json = File.ReadAllText(Application.streamingAssetsPath + "/Litjson.json");
        //JsonData是LitJson提供的类对象,可以用键值对的形式去访问其中的内容
        JsonData data = JsonMapper.ToObject(json);
        print(data["name"]);
        print(data["age"]);
        //通过泛型转换 更加方便 建议使用这种方式
        Mypeople2 t2= JsonMapper.ToObject<Mypeople2>(json);
        //注意:
        //1.类结构需要无参构造函数,否则反序列化时报错
        //2.字典虽然支持,但是键在使用时为数值会有问题 需要字符串类型
        #endregion

        #region 知识点五 注意事项
        //1.LitJson可以直接读取数据集合(数组)
        json = File.ReadAllText(Application.streamingAssetsPath + "/Roleinfo.json");
        RoleInfo2[] roleInfos = JsonMapper.ToObject<RoleInfo2[]>(json);
        //2.文本编码格式需要是UTF-8 不然无法加载
        #endregion

        #region 总结
        //1.Litjson提供的序列化反序列化方法 JsonMapper.Tojson和ToObject
        //2.LitJson无需加特性
        //3.LitJson不支持私有变量
        //4.LitJson支持字典序列化反序列化
        //5.LitJson可以直接将数据反序列化为数据集合
        //6.LitJson反序列化时 自定义类型需要无参构造

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
