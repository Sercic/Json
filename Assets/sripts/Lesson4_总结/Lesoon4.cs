using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesoon4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 总结

        #region MyRegion
        //1.和XML一致的优点
        //Json是国际通用规则
        //跨平台(游戏,软件,网页等等都能用,不同操作系统也能用)
        //文件结构清晰易懂
        //非常容易编辑和易懂
        //可以用于网络通信交换数据

        //2.可以利用Excel转Json帮着策划进行数据配置
        #endregion

        #region 缺点
        //重复工作繁多
        //自定义数据类,都需要自己去实现存储读取的功能
        //而且代码的相似度极高

        //数据容易被修改
        //只要找到文件位置,就可以轻易的进行数据修改
        #endregion

        #region 主要用处
        //网络游戏:
        //可以用于存储一些客户端的简单不重要数据
        //可以用于传输信息

        //单机游戏:
        //用于存储游戏相关数据
        //用于配置游戏数据(结合UGUI一起讲)
        #endregion
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
