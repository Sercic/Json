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
    public string name = "����";
    public int age = 10;
    public bool sex = true;
    public float testF = 1.111f;
    public double testD = 1.222d;

    public int[] ids = { 1, 2, 3 };
    public List<int> ids2 = new List<int> { 1, 2, 3 };
    //public Dictionary<int, string> dic = new() { { 1, "ֵ" }, { 2, "ֵ2" } };
    public Dictionary<string, string> dic2 = new() { { "��", "ֵ" }, { "��1", "ֵ2" } };

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
        #region ֪ʶ��һ LitJson��ʲô
        //����һ����������,���ڴ���Json�����л��ͷ����л�
        //Litjson��C#��д��,���С,�ٶȿ�,����ʹ��
        //�����Ժ����׵�Ƕ�뵽���ǵĴ�����
        //ֻ��Ҫ��ListJson���뿽���������м���
        #endregion

        #region ֪ʶ��� ��ȡLitJson
        //1.ǰ��ListJson����
        //2.ͨ������ǰ��Github��ȡ������汾
        //3.�����뿽����Unity������ ���ɿ�ʼʹ��LitJson
        #endregion

        #region ֪ʶ���� ʹ��LitJson�������л�
        //����:
        //JsonMapper.ToJson(����)
        Mypeople2 t = new Mypeople2();

        string json = JsonMapper.ToJson(t);
        print(Application.streamingAssetsPath);
        File.WriteAllText(Application.streamingAssetsPath + "/Litjson.json", json);
        //
        //ע��:
        //1.���JsonUtiliyt����Ҫ������
        //2.�������л�˽�б���
        //3.֧���ֵ�����
        //4.��Ҫ����LitJson�����ռ�
        //5.LitJson����׼ȷ�ı���null����
        #endregion

        #region ֪ʶ���� ʹ��LitJson�����л�
        //����:
        //JsonMapper.ToObject(�ַ���)
        json = File.ReadAllText(Application.streamingAssetsPath + "/Litjson.json");
        //JsonData��LitJson�ṩ�������,�����ü�ֵ�Ե���ʽȥ�������е�����
        JsonData data = JsonMapper.ToObject(json);
        print(data["name"]);
        print(data["age"]);
        //ͨ������ת�� ���ӷ��� ����ʹ�����ַ�ʽ
        Mypeople2 t2= JsonMapper.ToObject<Mypeople2>(json);
        //ע��:
        //1.��ṹ��Ҫ�޲ι��캯��,�������л�ʱ����
        //2.�ֵ���Ȼ֧��,���Ǽ���ʹ��ʱΪ��ֵ�������� ��Ҫ�ַ�������
        #endregion

        #region ֪ʶ���� ע������
        //1.LitJson����ֱ�Ӷ�ȡ���ݼ���(����)
        json = File.ReadAllText(Application.streamingAssetsPath + "/Roleinfo.json");
        RoleInfo2[] roleInfos = JsonMapper.ToObject<RoleInfo2[]>(json);
        //2.�ı������ʽ��Ҫ��UTF-8 ��Ȼ�޷�����
        #endregion

        #region �ܽ�
        //1.Litjson�ṩ�����л������л����� JsonMapper.Tojson��ToObject
        //2.LitJson���������
        //3.LitJson��֧��˽�б���
        //4.LitJson֧���ֵ����л������л�
        //5.LitJson����ֱ�ӽ����ݷ����л�Ϊ���ݼ���
        //6.LitJson�����л�ʱ �Զ���������Ҫ�޲ι���

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
