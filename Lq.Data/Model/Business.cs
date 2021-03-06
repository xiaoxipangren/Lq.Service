﻿using Lq.Data.Attribute;
using Lq.Data.Model.Security;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lq.Data.Model
{
    /// <summary>
    /// 商户用户
    /// </summary>
    [Table("merchantuser")]
    public class Merchant : User
    {
        [ColumnComment("商户描述")]
        public string Description { get; set; }
    }

    #region 商品

    #endregion
}