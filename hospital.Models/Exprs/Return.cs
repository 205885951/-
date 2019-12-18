using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 退货
    /// </summary>
   public class Return:BaseModels
    {
        /// <summary>
        /// 医院Id
        /// </summary>
        public  int HospitalId { get; set; }

        /// <summary>
        /// 药品Id
        /// </summary>
        public  int DrugMessageId { get; set; }
        /// <summary>
        /// 退货单价
        /// </summary>
        public  long Money { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public  int Shu { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public  int Dan { get; set; }
        /// <summary>
        /// 退货原因
        /// </summary>
        public  string Context { get; set; }
    }
}
