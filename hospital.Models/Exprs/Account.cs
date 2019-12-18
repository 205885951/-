using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 账户
    /// </summary>
    public class Account : BaseModels
    {
        /// <summary>
        /// 就诊卡Id
        /// </summary>
        public int PatientBlockId { get; set; }
       /// <summary>
       /// 余额
       /// </summary>
        public long Balance { get; set; }
    }

}
