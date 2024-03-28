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
    public string name = "����";
    public int age = 10;
    public bool sex = true;
    public float testF = 1.111f;
    public double testD = 1.222d;

    public int[] ids = { 1, 2, 3 };
    public List<int> ids2 = new List<int>{1,2,3};
    public Dictionary<int, string> dic = new() { { 1,"ֵ"},{ 2,"ֵ2"} };
    public Dictionary<string, string> dic2 = new() { { "��", "ֵ" } ,{ "��1","ֵ2" } };

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
        #region ֪ʶ��һ JsonUtlity��ʲô?
        //JsonUtlity ��Unity�Դ������ڽ���Json�Ĺ�����
        //������
        //1.���ڴ��ж������л�ΪJson��ʽ���ַ���
        //2.��Json�ַ��������л�Ϊ�����
        #endregion

        #region ֪ʶ��� �ر�֪ʶ�㡪�����д���ַ���
        //1.�洢�ַ�����ָ��·���ļ���
        //��һ������ ��д���Ǵ洢��·��
        //�ڶ������� ��д���Ǵ洢���ַ�������
        File.WriteAllText(Application.persistentDataPath + "/Json/Test.json", "�Ҵ洢��json�ļ�");
        print(Application.persistentDataPath);
        //ע��:ͨ�������ķ�ʽ���д洢,һ��Ҫ��֤·���ļ��Ǵ��ڵ�,��Ȼ�ᱨ��

        //2.��ָ��·���ļ��ж�ȡ�ַ���
        string str = File.ReadAllText(Application.persistentDataPath + "/Json/Test.json");
        print(str);
        #endregion

        #region ֪ʶ���� ʹ��JsonUtlity�������л�
        //���л�:���ڴ��е����� �洢��Ӳ����
        //����:
        //JsonUtlity.ToJson(����)

        Mypeople t = new Mypeople();

        //Unity�ṩ���ֳɵķ��� ���԰������ ���л�Ϊ json�ַ���
        string jsonString = JsonUtility.ToJson(t);
        File.WriteAllText(Application.persistentDataPath + "/MyPeople.json", jsonString);
        

        //ע��:
        //1.float���л�ʱ����������һЩ���
        //2.�Զ�������Ҫ�������л�����[System.Serializable]
        //3.��Ҫ���л�˽�б��� ��Ҫ��������[SerializeField]
        //4.JsonUtlity��֧���ֵ�
        //5.JsonUtlity�洢null���󲻻���null ����Ĭ��ֵ������
        #endregion

        #region ֪ʶ���� ʹ��JsonUtlity���з����л�
        //�����л�:��Ӳ���ϵ����� ��ȡ���ڴ���
        //����:
        //JsonUtlity.FromJson(�ַ���)
        //��ȡ�ļ��е�json�ַ���
        jsonString = File.ReadAllText(Application.persistentDataPath + "/MyPeople.json");
        //ʹ��Json�ַ������� ת���������
        Mypeople t2 = JsonUtility.FromJson(jsonString,typeof(Mypeople)) as Mypeople;
        Mypeople t3 = JsonUtility.FromJson<Mypeople>(jsonString);

        //ע��:
        //���Json����������,��ȡ���ڴ��������ʱ���ᱨ��
        #endregion

        #region ֪ʶ���� ע������
        //1.JsonUtility�޷�ֱ�Ӷ�ȡ���ݼ���
        jsonString = File.ReadAllText(Application.streamingAssetsPath + "/Roleinfo2.json");
        //print(jsonString);

        //�����Ǵ����
        //List<RoleInfo> roleInfoList = JsonUtility.FromJson<List<RoleInfo>>(jsonString);

        //��RoleData������һ��
        RoleData data = JsonUtility.FromJson<RoleData>(jsonString);
        //2.�ı������ʽ��ҪUTF-8 ��Ȼ�޷�����
        #endregion

        #region �ܽ�
        //1.�ر�֪ʶ�� ����File����ַ����ķ���:ReadAllText��WriteAllText   
        //2.JsonUtility�ṩ�����л����� ToJson �� FromJson
        //3.�Զ�������Ҫ�������л�����[System.Serializable]
        //4.˽�б�����Ա ��Ҫ����[SerializeField]
        //5.JsonUtility��֧���ֵ�
        //6.JsonUtiity����ֱ�ӽ����ݷ����л�Ϊ���ݼ���
        //7.Json�ĵ������ʽ������UTF-8

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
