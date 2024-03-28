using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 JsonUtility和LitJson相同点
        //1.他们都是用于Json的序列化反序列化
        //2.Json文档编码格式必须时UTF-8
        //3.都是通过静态类进行方法调用
        #endregion

        #region 知识点二 JsonUtility和LitJson不同点
        //1.JsonUtility是Unity自带,LitJson是第三方需要引用命名空间
        //2.JsonUtility是使用自定义类需要加特性,LitJson不需要
        //3.JsonUtility支持私有变量(加特性),LitJson不需要
        //4.JsonUtility不支持字典,LitJson支持(但是键只能是字符串)
        //5.JsonUtility对自定义类不要求有无参构造,LitJson需要
        //6.JsonUtility对自定义类不要求有无参构造,LitJson需要
        //7.JsonUtility存储空对象时会存储默认值而不是null,LitJson会存null
        #endregion

        #region 知识点三 如何选择两者
        //根据实际需求
        //建议使用LitJson
        //原因:Litjson不用加特性,支持字典,支持直接反序列化为数据集合(数组,List),存储null更准确
        #endregion
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
