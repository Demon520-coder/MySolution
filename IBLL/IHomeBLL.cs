﻿
using System.ServiceModel;

namespace Langben.IBLL
{
    /// <summary>
    /// 接口
    /// </summary>
    [ServiceContract(Namespace = "http://temp.org")]
    public interface IHomeBLL
    {
        /// <summary>
        /// 根据PersonId获取已经启用的菜单
        /// </summary>
        /// <param name="personId">人员的Id</param>
        /// <returns>菜单拼接的字符串</returns>
        string GetMenuByAccount(ref Common.Account account);
    }
}

