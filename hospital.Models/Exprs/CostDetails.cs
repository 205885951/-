using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Models
{
    /// <summary>
    /// 药品收费详情
    /// </summary>
  public  class CostDetails:BaseModels
    {
        /// <summary>
        /// 药品Id
        /// </summary>
        public  int DrugMessageId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public  int Quantity { get; set; }
        /// <summary>
        /// 小计总金额
        /// </summary>
        public  long Subtotal { get; set; }
    }
}
