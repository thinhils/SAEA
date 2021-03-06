﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：Microsoft
*命名空间：SAEA.MVC
*文件名： HttpGet
*版本号： V3.3.3.3
*唯一标识：e00bb57f-e3ee-4efe-a7cf-f23db767c1d0
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/4/10 16:43:26
*描述：
*
*=====================================================================
*修改标记
*修改时间：2018/4/10 16:43:26
*修改人： yswenli
*版本号： V3.3.3.3
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.MVC
{
    /// <summary>
    /// 标记方法为GET
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class HttpGet : Attribute
    {

    }
}
