using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Json基础语法
{

    #region 用什么编辑Json文件
    //只要能打开文档的软件都能打开Json文件
    //常用的一些编辑Json文件的方式
    //1.系统自带——记事本,写字板
    //2.通用文本编辑器——Sublime Text等等
    //3.网页上的Json编辑器
    #endregion

    #region 创建Json文件
    //直接右键创建文本,后缀改为json
    //选择自己喜欢的用于编辑Json的软件
    //进行文本编辑
    #endregion

    #region 注释
    //和C#中注释方式一致
    //1.双斜杠//注释内容
    //2.斜杠加星号/*注释内容*/
    #endregion

    #region Json格式是一种键值对结构

    #endregion

    #region 语法规则
    //符号含义:
    //大括号{}——对象
    //中括号[]——数组
    //冒号:   ——键值对对应关系
    //逗号,   ——数据分割
    //双引号""——键名/字符串

    //键值对表示:
    //  "键名":值内容
    //  值类型
    //  数字(整数或浮点)
    //  字符串
    //  bool类型
    //  数组
    //  对象
    //  null
    #endregion

    #region 配置Json文档时的注意事项
    //1.如果数据表示对象那么最外层有大括号
    //2.一定是键值对形式
    //3.键一定是字符串形式
    //4.键值对用逗号分开
    //5.数组用[]包裹
    //6.对象用{}包裹
    #endregion

    #region 总结
    //1.创建Json文件 —— 右键创建文档改后缀
    //2.注释 —— //和/* */
    //3.语法规则 —— 对象用大括号,数组用中括号,键值对用冒号,数据分割用逗号

    //注意事项要基佬
    #endregion
}
