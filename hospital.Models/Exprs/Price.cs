using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models.Exprs
{
    /// <summary>
    /// 药品价格
    /// </summary>
   public class Price:BaseModels
    {
        /// <summary>
        /// 药品Id
        /// </summary>
        public  int DrugMessageId { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public  string Dan { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public  long Money { get; set; }

    }
}
