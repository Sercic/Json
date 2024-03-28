using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Json概述 : MonoBehaviour
{
    #region Json是什么?
    //全称:JsonScript对象简谱
    //Json是国际通用的一种轻量级的数据交换格式
    //主要在网络通讯中用于传输数据,或本地数据存储和读取
    //易于人阅读和编写,同时也易于机器解析和生成,并有效地提升网络传输效率
    #endregion

    #region 我们一般使用Json文件来记录和传输数据
    //Json文档就是使用Json格式配置填写的文档
    //后缀一般为.Json
    //我们在游戏中可以把游戏数据按照Json的格式标准
    //存储在Json文档中,再将Json文档存储在硬盘上或者传输给远端
    //达到数据持久化或者数据传输的目的
    #endregion

    #region Xml和Json的异同
    //共同点           不同点
    //1.都是纯文本     2.Json配置更简单
    //2.都有层级结构   2.Json在某些情况下读写更迅速
    //3.都具有描述性
    #endregion

    #region 学会后对于我们的意义
    //1.多了一种存储和传输数据的选择
    //2.多了一种配置数据的方法(具体会结合UI第三部曲讲解)
    #endregion

    #region 总结
    //1.掌握Json的基础规则
    //2.掌握C#读取存储Json文件
    #endregion
}
